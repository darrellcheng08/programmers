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
    public partial class Section : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        string uID, loginID;

        public Section()
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
            cmd = new OdbcCommand("Select sectionID from tbl_section", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string strid = dr["sectionID"].ToString();
                if (strid == "")
                {
                    txtSecID.Text = "0000" + 1;
                    myID = 1;
                }
                else
                {
                    myID = Convert.ToInt32(dr["sectionID"]) + 1;
                    txtSecID.Text = "0000" + myID.ToString();
                }
            }
            cmd.Dispose();
            con.Close();

            cmbYearLevel.Items.Clear();
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

            lvwListSection.Items.Clear();
             query = "Select * from tbl_section";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListSection.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(5).ToString());
                list.SubItems.Add(dr.GetValue(6).ToString());
                list.SubItems.Add(dr.GetValue(7).ToString());
            }
            dr.Close();
            con.Close();
        }

        void reset()
        {
            txtSecName.Text = "";
            cmbYearLevel.Text = "";
            txtClassName.Text = "";
            txtMinAverage.Text = "";
            txtMaxAverage.Text = "";
            txtStudAllowed.Text = "";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "New")
            {
                load();
                reset();
                lockcontrol();
            }
            if (txtSecID.Text == "")
            {
                MessageBox.Show("Section ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecID.Focus();
                return;
            }
            else if (txtSecName.Text == "")
            {
                MessageBox.Show("Section Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecName.Focus();
                return;
            }
            else if (cmbYearLevel.Text == "")
            {
                MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYearLevel.Focus();
                return;
            }
            else if (txtClassName.Text == "")
            {
                MessageBox.Show("Class Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassName.Focus();
                return;
            }
            else if (txtMinAverage.Text == "")
            {
                MessageBox.Show("Minimum Average CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinAverage.Focus();
                return;
            }
            else if (txtMaxAverage.Text == "")
            {
                MessageBox.Show("Maximum Average CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaxAverage.Focus();
                return;
            }
            else if (txtStudAllowed.Text == "")
            {
                MessageBox.Show("Number Of Student Allowed CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudAllowed.Focus();
                return;
            }
            else
            {
                string query = "SELECT * FROM tbl_section WHERE SectionName='"+txtSecName.Text+"'";
                cmd = new OdbcCommand(query,con);
                con.Open();
                dr = cmd.ExecuteReader();
                while(dr.HasRows)
                {
                        MessageBox.Show("This Section Name " + dr[1].ToString() + " is already added,Please try another one!", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                        txtSecName.Focus();
                        return;
                }
                dr.Close();
                con.Close();

                cmd = new OdbcCommand("INSERT INTO tbl_section(sectionid,sectionName,yearlevel,className,MinimumAverage,MaximumAverage,NumberOfStudentAllowed,DateCreated) VALUES ('" + txtSecID.Text + "','" + txtSecName.Text + "','" + cmbYearLevel.Text + "','" + txtClassName.Text + "','" + txtMinAverage.Text + "','" + txtMaxAverage.Text + "','" + txtStudAllowed.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New entry successfully saved to the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                reset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSecID.Text == "")
            {
                MessageBox.Show("Section ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecID.Focus();
                return;
            }
            else if (txtSecName.Text == "")
            {
                MessageBox.Show("Section Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecName.Focus();
                return;
            }
            else if (cmbYearLevel.Text == "")
            {
                MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYearLevel.Focus();
                return;
            }
            else if (txtClassName.Text == "")
            {
                MessageBox.Show("Class Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassName.Focus();
                return;
            }
            else if (txtMinAverage.Text == "")
            {
                MessageBox.Show("Minimum Average CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinAverage.Focus();
                return;
            }
            else if (txtMaxAverage.Text == "")
            {
                MessageBox.Show("Maximum Average CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaxAverage.Focus();
                return;
            }
            else if (txtStudAllowed.Text == "")
            {
                MessageBox.Show("Number Of Student Allowed CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudAllowed.Focus();
                return;
            }
            else
            {
                cmd = new OdbcCommand("UPDATE tbl_section SET SectionName='" + txtSecName.Text + "',YearLevel='" + cmbYearLevel.Text + "',ClassName='" + txtClassName.Text + "',MinimumAverage='" + txtMinAverage.Text + "',MaximumAverage='" + txtMaxAverage.Text + "',NumberOfStudentAllowed='" + txtStudAllowed.Text + "' where SectionID='" + txtSecID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lockcontrol();
                load();
                reset();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cmd = new OdbcCommand("DELETE FROM tbl_section where SectionID='" + txtSecID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Delete!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lockcontrol();
                load();
                reset();
            }
        }

        private void Section_Load(object sender, EventArgs e)
        {
            lockcontrol();
            load();
        }

        private void lvwListSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSecID.Text = lvwListSection.FocusedItem.SubItems[0].Text;
            txtSecName.Text = lvwListSection.FocusedItem.SubItems[1].Text;
            cmbYearLevel.Text = lvwListSection.FocusedItem.SubItems[2].Text;
            txtClassName.Text = lvwListSection.FocusedItem.SubItems[3].Text;
            txtMinAverage.Text = lvwListSection.FocusedItem.SubItems[4].Text;
            txtMaxAverage.Text = lvwListSection.FocusedItem.SubItems[5].Text;
            txtStudAllowed.Text = lvwListSection.FocusedItem.SubItems[6].Text;
            unlock();
        }

        private void txtSearchLast_TextChanged(object sender, EventArgs e)
        {
            lvwListSection.Items.Clear();
            string query = "Select * from tbl_section WHERE SectionName='"+ txtSearchLast +"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListSection.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(5).ToString());
                list.SubItems.Add(dr.GetValue(6).ToString());
                list.SubItems.Add(dr.GetValue(7).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSecName_TextChanged(object sender, EventArgs e)
        {
            if(txtSecName.Text == "")
            {
                txtSecName.Text = "";
                cmbYearLevel.Text = "";
            }
            txtClassName.Text = Convert.ToString(cmbYearLevel.Text + "-" + txtSecName.Text);
        }

        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtClassName.Text = Convert.ToString(cmbYearLevel.Text);
            txtClassName.Text = Convert.ToString(cmbYearLevel.Text + "-" + txtSecName.Text);
        }
    }
}
