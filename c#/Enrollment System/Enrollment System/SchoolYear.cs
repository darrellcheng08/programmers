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
    public partial class SchoolYear : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        string uID, loginID;

        public SchoolYear()
        {
            InitializeComponent();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        void loadAll()
        {
            try
            {
                cmd = new OdbcCommand("select schoolyearid from tbl_schoolyear", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["schoolyearid"].ToString();
                    if (strid == "")
                    {
                        txtSchoolYearID.Text = "0000" + 1;
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["schoolyearid"]) + 1;
                        txtSchoolYearID.Text = "0000" + myID.ToString();
                    }
                }
                cmd.Dispose();
                con.Close();

                lvwListSchoolYear.Items.Clear();
                string query = "SELECT * FROM tbl_schoolyear ORDER BY SchoolYear";
                con.Open();
                cmd = new OdbcCommand(query, con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ListViewItem list = new ListViewItem();

                    list = lvwListSchoolYear.Items.Add(dr.GetValue(0).ToString());
                    list.SubItems.Add(dr.GetValue(1).ToString());
                    list.SubItems.Add(dr.GetValue(2).ToString());
                    list.SubItems.Add(dr.GetValue(3).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void reset()
        {
            txtSYfrom.Text = "";
            txtSY.Text = "";
            txtSYto.Text = "";
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

        private void SchoolYear_Load(object sender, EventArgs e)
        {
            loadAll();
            lockcontrol();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (btnSave.Text == "New")
                {
                    loadAll();
                    reset();
                    lockcontrol();
                }
                if (txtSchoolYearID.Text == "")
                {
                    MessageBox.Show("School Year ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSchoolYearID.Focus();
                    return;
                }
                else if (txtSYfrom.Text == "")
                {
                    MessageBox.Show("School Year CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSYfrom.Focus();
                    return;
                }
                else
                {

                    string query = "SELECT * from tbl_SchoolYear WHERE SchoolYear like '"+ txtSY.Text +"'";
                    cmd = new OdbcCommand(query,con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while(dr.HasRows)
                    {
                        MessageBox.Show("This year " + dr[1].ToString() +  " is already added,Please try another one!", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                        txtSY.Focus();
                        return;
                    }
                    dr.Close();

                    cmd = new OdbcCommand("INSERT INTO tbl_schoolyear(Schoolyearid,Schoolyear,Status,DateCreated) VALUES ('" + txtSchoolYearID.Text + "','"+ txtSY.Text +"','Inactive','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New entry successfully saved to the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lockcontrol();
                    loadAll();
                    reset();
                }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSchoolYearID.Text == "")
                {
                    MessageBox.Show("School Year ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSchoolYearID.Focus();
                    return;
                }
                else if (txtSYfrom.Text == "")
                {
                    MessageBox.Show("School Year CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSYfrom.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * from tbl_SchoolYear WHERE SchoolYear like '" + txtSY.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.HasRows)
                    {
                        MessageBox.Show("This year " + dr[1].ToString() + " is already added,Please try another one!", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                        txtSY.Focus();
                        return;
                    }
                    dr.Close();
                    con.Open();

                    cmd = new OdbcCommand("UPDATE tbl_schoolyear SET schoolyear='" + txtSY.Text + "' where schoolyearid='" + txtSchoolYearID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lockcontrol();
                    loadAll();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    cmd = new OdbcCommand("DELETE FROM tbl_schoolyear where schoolyearid='" + txtSchoolYearID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Delete!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lockcontrol();
                    loadAll();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwListSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSchoolYearID.Text = lvwListSchoolYear.FocusedItem.SubItems[0].Text;
            txtSY.Text = lvwListSchoolYear.FocusedItem.SubItems[1].Text;
            //txtSYto.Text = lvwListSchoolYear.FocusedItem.SubItems[2].Text;
            unlock();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lvwListSchoolYear.Items.Clear();
            string query = "SELECT * FROM tbl_schoolyear WHERE SchoolYear like '"+txtSearch.Text+"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListSchoolYear.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtSYfrom_TextChanged(object sender, EventArgs e)
        {
            if(txtSYfrom.Text == "")
            {
                txtSYfrom.Text = "";
                txtSYto.Text = "";
                return;
            }
            txtSYto.Text = Convert.ToString(Convert.ToInt32(txtSYfrom.Text) + 1);
            txtSY.Text = Convert.ToString(txtSYfrom.Text +"-"+ txtSYto.Text);
        }
    }
}
