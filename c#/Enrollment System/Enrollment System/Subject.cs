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
    public partial class Subject : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;
        string uID, loginID;

        public Subject()
        {
            InitializeComponent();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        void load()
        {
            try
            {
                lvwListSubject.Items.Clear();
                string query = "Select * from tbl_subject";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ListViewItem list = new ListViewItem();

                    list = lvwListSubject.Items.Add(dr.GetValue(0).ToString());
                    list.SubItems.Add(dr.GetValue(1).ToString());
                    list.SubItems.Add(dr.GetValue(2).ToString());
                    list.SubItems.Add(dr.GetValue(3).ToString());
                    list.SubItems.Add(dr.GetValue(4).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void autosecID()
        {
            try
            {
                cmd = new OdbcCommand("Select subjectid from tbl_Subject", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["subjectid"].ToString();
                    if (strid == "")
                    {
                        txtsubID.Text = "0000" + 1;
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["subjectid"]) + 1;
                        txtsubID.Text = "0000" + myID.ToString();
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

        void cmbyearlevelfill()
        {
            try
            {
                string query = "SELECT * FROM year_level";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbYearLevel.Items.Add(dr.GetValue(1).ToString());
                }
                dr.Close();
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

        void reset()
        {
            txtSubject.Text = "";
            txtDescription.Text = "";
            cmbYearLevel.Text = "";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "New")
                {
                    autosecID();
                    reset();
                    lockcontrol();
                }

                if (txtsubID.Text == "")
                {
                    MessageBox.Show("SubjectID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsubID.Focus();
                    return;
                }
                else if (txtSubject.Text == "")
                {
                    MessageBox.Show("Subject CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSubject.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else if (cmbYearLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbYearLevel.Focus();
                    return;
                }
                else
                {
                    con.Open();
                    string query = "SELECT * FROM tbl_subject WHERE Subject like '" + txtSubject.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("The " + txtSubject.Text + " is already added to " + cmbYearLevel.Text + ", try another one", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                        txtSubject.Focus();
                        dr.Close();
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_subject(subjectID,Subject,Description,YearLevel,DateCreated) VALUES ('" + txtsubID.Text + "','" + txtSubject.Text + "','" + txtDescription.Text + "','" + cmbYearLevel.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subject is successfully assigned to " + cmbYearLevel.Text + "", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                        reset();
                        autosecID();
                    }
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
                if (txtsubID.Text == "")
                {
                    MessageBox.Show("SubjectID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsubID.Focus();
                    return;
                }
                else if (txtSubject.Text == "")
                {
                    MessageBox.Show("Subject CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSubject.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else if (cmbYearLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbYearLevel.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * FROM tbl_subject WHERE Subject like '" + txtSubject.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("The " + txtSubject.Text + " is already added to " + cmbYearLevel.Text + ", try another one", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                        txtSubject.Focus();
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("UPDATE tbl_subject set subject='" + txtSubject.Text + "',Description='" + txtDescription.Text + "',YearLevel='" + cmbYearLevel.Text + "' WHERE subjectid='" + txtsubID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    reset();
                    autosecID();
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
                    cmd = new OdbcCommand("DELETE from tbl_subject where subjectid= '" + txtsubID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Delete!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    reset();
                    autosecID();
                    lockcontrol();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lvwListSubject.Items.Clear();
                string query = "Select * from tbl_subject WHERE Subject='"+txtSearch.Text+"%'";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem list = new ListViewItem();

                    list = lvwListSubject.Items.Add(dr.GetValue(0).ToString());
                    list.SubItems.Add(dr.GetValue(1).ToString());
                    list.SubItems.Add(dr.GetValue(2).ToString());
                    list.SubItems.Add(dr.GetValue(3).ToString());
                    list.SubItems.Add(dr.GetValue(4).ToString());
                }
                dr.Close();
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            autosecID();
            cmbyearlevelfill();
            load();
            lockcontrol();
        }

        private void lvwListSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsubID.Text = lvwListSubject.FocusedItem.SubItems[0].Text;
            txtSubject.Text = lvwListSubject.FocusedItem.SubItems[1].Text;
            txtDescription.Text = lvwListSubject.FocusedItem.SubItems[2].Text;
            cmbYearLevel.Text = lvwListSubject.FocusedItem.SubItems[3].Text;
            unlock();
        }
    }
}
