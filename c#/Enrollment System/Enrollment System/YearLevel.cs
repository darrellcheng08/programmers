using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Enrollment_System
{
    public partial class YearLevel : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        string uID, loginID;

        public YearLevel()
        {
            InitializeComponent();
        }

        void reset()
        {
            txtYearLevel.Text = "";
            txtDescription.Text = "";
        }

        void yearlevelID()
        {
            try
            {
                cmd = new OdbcCommand("select yearid from year_level", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["yearid"].ToString();
                    if (strid == "")
                    {
                        txtYearID.Text = "0000" + "1";
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["yearid"]) + 1;
                        txtYearID.Text = "0000" + myID.ToString();
                    }
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void lockcontrol()
        {
            btnSave.Text = "Save";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        void unlock()
        {
            btnSave.Text = "New";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        void load()
        {
            lvwListYearLevel.Items.Clear();
            string query = "Select * from Year_Level";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListYearLevel.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
            }
            dr.Close();
            con.Close();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X + e.X) - offsetX, (Location.Y + e.Y) - offsetY);
            }
        }
        int offsetX;
        int offsetY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offsetX = e.X;
            offsetY = e.Y;
            mouseDown = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd = new OdbcCommand("DELETE from year_level WHERE yearID='" + txtYearID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Delete!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    reset();
                    yearlevelID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtYearID.Text == "")
                {
                    MessageBox.Show("YearID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYearID.Focus();
                    return;
                }
                else if (txtYearLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYearLevel.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * FROM year_level WHERE YearLevel='" + txtYearLevel.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Year Level you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtYearLevel.Text = "";
                        txtDescription.Text = "";
                        txtYearLevel.Focus();
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("UPDATE year_level SET YearLevel='" + txtYearLevel.Text + "',Description='" + txtDescription.Text + "' WHERE YearID='" + txtYearID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    reset();
                    yearlevelID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "New")
                {
                    yearlevelID();
                    reset();
                    lockcontrol();
                }
                if (txtYearID.Text == "")
                {
                    MessageBox.Show("YearID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYearID.Focus();
                    return;
                }
                else if (txtYearLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYearLevel.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else
                {
                    con.Open();
                    string query = "SELECT * FROM year_level WHERE YearLevel='" + txtYearLevel.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Year Level you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtYearLevel.Text = "";
                        txtDescription.Text = "";
                        txtYearLevel.Focus();
                        dr.Close();
                    }
                    else
                    {

                        cmd = new OdbcCommand("Insert into year_level(YearID,YearLevel,Description,DateCreated) VALUES ('" + txtYearID.Text + "','" + txtYearLevel.Text + "','" + txtDescription.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
                        //con.Open();
                        cmd.ExecuteNonQuery();
                        //con.Close();
                        MessageBox.Show("New entry successfully saved to the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                        reset();
                        yearlevelID();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwListYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYearID.Text = lvwListYearLevel.FocusedItem.SubItems[0].Text;
            txtYearLevel.Text = lvwListYearLevel.FocusedItem.SubItems[1].Text;
            txtDescription.Text = lvwListYearLevel.FocusedItem.SubItems[2].Text;
            unlock();
        }

        private void YearLevel_Load(object sender, EventArgs e)
        {
            try
            {
                yearlevelID();
                load();
                lockcontrol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchLast_TextChanged(object sender, EventArgs e)
        {
            lvwListYearLevel.Items.Clear();
            string query = "Select * from Year_Level WHERE Yearlevel like '"+txtSearch.Text+"%'";
            cmd = new OdbcCommand(query,con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListYearLevel.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
