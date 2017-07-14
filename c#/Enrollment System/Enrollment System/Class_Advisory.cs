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
    public partial class Class_Advisory : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;
        string uID, loginID;

        public Class_Advisory()
        {
            InitializeComponent();
        }

        void viewColor()
        {
            foreach (ListViewItem item in lvwListAdvisory.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = Color.White;
                else
                    item.BackColor = Color.LightGray;
            }
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
                string query = "SELECT * FROM tbl_schoolyear WHERE Status='Active'";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbSchoolYear.Items.Add(dr.GetValue(1).ToString());
                }
                dr.Close();
                con.Close();

                cmbYearLevel.Items.Clear();
                query = "SELECT * FROM year_level";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbYearLevel.Items.Add(dr.GetValue(1).ToString());
                }
                dr.Close();
                con.Close();

                cmbYearLevel.Items.Clear();
                query = "SELECT * FROM year_level";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbYearLevel.Items.Add(dr.GetValue(1).ToString());
                }
                dr.Close();
                con.Close();

                cmbClassName.Items.Clear();
                query = "SELECT * FROM tbl_Section";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbClassName.Items.Add(dr.GetValue(3).ToString());
                }
                dr.Close();
                con.Close();

                cmd = new OdbcCommand("select AdvisoryID from tbl_advisory", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["AdvisoryID"].ToString();
                    if (strid == "")
                    {
                        txtAdvisoryID.Text = "0000" + 1;
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["AdvisoryID"]) + 1;
                        txtAdvisoryID.Text = "0000" + myID.ToString();
                    }
                }
                cmd.Dispose();
                con.Close();

                lvwListAdvisory.Items.Clear();
                query = "SELECT * FROM tbl_advisory ORDER BY AdvisoryID";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ListViewItem list = new ListViewItem();

                    list = lvwListAdvisory.Items.Add(dr.GetValue(0).ToString());
                    list.SubItems.Add(dr.GetValue(1).ToString());
                    list.SubItems.Add(dr.GetValue(2).ToString());
                    list.SubItems.Add(dr.GetValue(3).ToString());
                    list.SubItems.Add(dr.GetValue(4).ToString());
                    list.SubItems.Add(dr.GetValue(5).ToString());
                    list.SubItems.Add(dr.GetValue(6).ToString());
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
            cmbSchoolYear.Text = "";
            txtTeacher.Text = "";
            lblID.Text = "";
            cmbYearLevel.Text = "";
            cmbClassName.Text = "";
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

        public void TeacherName(string Teacherid, string FirstName, string MiddleName, string LastName)
        {
            lblID.Text = Teacherid;
            txtTeacher.Text = LastName + "," + " " + FirstName + MiddleName;
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

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Search_Teacher searc = new Search_Teacher(this);
            searc.ShowDialog();
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
                    loadAll();
                    reset();
                    lockcontrol();
                }
                if (txtAdvisoryID.Text == "")
                {
                    MessageBox.Show("Advisory ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdvisoryID.Focus();
                    return;
                }
                else if (cmbSchoolYear.Text == "")
                {
                    MessageBox.Show("School Year CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSchoolYear.Focus();
                    return;
                }
                else if (txtTeacher.Text == "")
                {
                    MessageBox.Show("Teacher Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTeacher.Focus();
                    return;
                }
                else if (lblID.Text == "")
                {
                    MessageBox.Show("Teacher ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblID.Focus();
                    return;
                }
                else if (cmbYearLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbYearLevel.Focus();
                    return;
                }
                else if (cmbClassName.Text == "")
                {
                    MessageBox.Show("Class Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClassName.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * from tbl_Advisory WHERE TeacherName like '" + txtTeacher.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.HasRows)
                    {
                        MessageBox.Show("This Teacher Name " + dr[3].ToString() + " is already Assign "+ dr[5].ToString() +"", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTeacher.Text = "";
                        txtTeacher.Focus();
                        return;
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("INSERT INTO tbl_advisory(AdvisoryID,SchoolYear,TeacherName,TeacherID,YearLevel,ClassName,DateCreated) VALUES ('" + txtAdvisoryID.Text + "','" + cmbSchoolYear.Text + "','" + txtTeacher.Text + "','" + lblID.Text + "','" + cmbYearLevel.Text + "','" + cmbClassName.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New entry successfully saved to the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdvisoryID.Text == "")
                {
                    MessageBox.Show("Advisory ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdvisoryID.Focus();
                    return;
                }
                else if (cmbSchoolYear.Text == "")
                {
                    MessageBox.Show("School Year CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSchoolYear.Focus();
                    return;
                }
                else if (txtTeacher.Text == "")
                {
                    MessageBox.Show("Teacher Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTeacher.Focus();
                    return;
                }
                else if (lblID.Text == "")
                {
                    MessageBox.Show("Teacher ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblID.Focus();
                    return;
                }
                else if (cmbYearLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbYearLevel.Focus();
                    return;
                }
                else if (cmbClassName.Text == "")
                {
                    MessageBox.Show("Class Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClassName.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * from tbl_Advisory WHERE TeacherName like '" + txtTeacher.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.HasRows)
                    {
                        MessageBox.Show("This Teacher Name " + dr[3].ToString() + " is already Assign to "+ dr[5].ToString() +"", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTeacher.Text = "";
                        txtTeacher.Focus();
                        return;
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("UPDATE tbl_Advisory SET SchoolYear='" + cmbSchoolYear.Text + "',TeacherName='" + txtTeacher.Text + "',TeacherID='" + lblID.Text + "',YearLevel='" + cmbYearLevel.Text + "',ClassName='" + cmbClassName.Text + "' WHERE AdvisoryID='" + txtAdvisoryID.Text + "'", con);
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
                    cmd = new OdbcCommand("DELETE FROM tbl_advisory WHERE advisoryID='" + txtAdvisoryID.Text + "'", con);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Class_Advisory_Load(object sender, EventArgs e)
        {
            loadAll();
            lockcontrol();
        }

        private void lvwListAdvisory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdvisoryID.Text = lvwListAdvisory.FocusedItem.SubItems[0].Text;
            cmbSchoolYear.Text = lvwListAdvisory.FocusedItem.SubItems[1].Text;
            lblID.Text = lvwListAdvisory.FocusedItem.SubItems[2].Text;
            txtTeacher.Text = lvwListAdvisory.FocusedItem.SubItems[3].Text;
            cmbYearLevel.Text = lvwListAdvisory.FocusedItem.SubItems[4].Text;
            cmbClassName.Text = lvwListAdvisory.FocusedItem.SubItems[5].Text;
            unlock();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lvwListAdvisory.Items.Clear();
            string query = "SELECT * FROM tbl_advisory where TeacherID='"+ txtSearch.Text +"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListAdvisory.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(5).ToString());
                list.SubItems.Add(dr.GetValue(6).ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
