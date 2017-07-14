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
    public partial class Teachers : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;
        string uID, loginID;

        public Teachers()
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
            lvwListTeacher.Items.Clear();
            string query = "SELECT * FROM Teacher_Info";
            cmd = new OdbcCommand(query,con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
            ListViewItem list = new ListViewItem();

            list = lvwListTeacher.Items.Add(dr.GetValue(0).ToString());
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

        void autoTeacherID()
        {
            try
            {
                cmd = new OdbcCommand("select TeacherID from Teacher_Info", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["TeacherID"].ToString();
                    if (strid == "")
                    {
                        txtTeachID.Text = "0000" + 1;
                        myID = 1;
                    }
                    else
                    {
                        // myID = dr["TeacherID"].ToString();
                        myID++;
                        txtTeachID.Text = DateTime.Now.Year + "-" + "0000" + myID.ToString();
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

        void reset()
        {
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            cmbPosition.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
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
            try
            {
                if (btnSave.Text == "New")
                {
                    autoTeacherID();
                    reset();
                    lockcontrol();
                }
                if (txtTeachID.Text == "")
                {
                    MessageBox.Show("Teacher ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTeachID.Focus();
                    return;
                }
                else if (txtFName.Text == "")
                {
                    MessageBox.Show("First Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFName.Focus();
                    return;
                }
                else if (txtMName.Text == "")
                {
                    MessageBox.Show("Middle Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMName.Focus();
                    return;
                }
                else if (txtLName.Text == "")
                {
                    MessageBox.Show("Last Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLName.Focus();
                    return;
                }
                else if (cmbPosition.Text == "")
                {
                    MessageBox.Show("Position CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPosition.Focus();
                    return;
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Address CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }
                else if (txtContact.Text == "")
                {
                    MessageBox.Show("Contact Number CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContact.Focus();
                    return;
                }
                else
                {
                    cmd = new OdbcCommand("INSERT INTO Teacher_Info(TeacherID,FirstName,MiddleName,LastName,Position,Address,Contact,DateCreated) VALUES ('" + txtTeachID.Text + "','" + txtFName.Text + "','" + txtMName.Text + "','" + txtLName.Text + "','" + cmbPosition.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New entry successfully saved to the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    reset();
                    autoTeacherID();
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
                cmd = new OdbcCommand("UPDATE Teacher_Info SET FirstName='" + txtFName.Text + "',MiddleName='" + txtMName.Text + "',LastName='" + txtLName.Text + "',Position='" + cmbPosition.Text + "',Address='" + txtAddress.Text + "',Contact='" + txtContact.Text + "' WHERE TeacherID='" + txtTeachID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                reset();
                autoTeacherID();
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
                    cmd = new OdbcCommand("DELETE FROM Teacher_Info WHERE TeacherID='" + txtTeachID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Delete!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    reset();
                    autoTeacherID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            autoTeacherID();
            load();
            lockcontrol();
        }

        private void lvwListTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTeachID.Text = lvwListTeacher.FocusedItem.SubItems[0].Text;
            txtFName.Text = lvwListTeacher.FocusedItem.SubItems[1].Text;
            txtMName.Text = lvwListTeacher.FocusedItem.SubItems[2].Text;
            txtLName.Text = lvwListTeacher.FocusedItem.SubItems[3].Text;
            cmbPosition.Text = lvwListTeacher.FocusedItem.SubItems[4].Text;
            txtAddress.Text = lvwListTeacher.FocusedItem.SubItems[5].Text;
            txtContact.Text = lvwListTeacher.FocusedItem.SubItems[6].Text;
            unlock();
        }

        private void txtSearchLast_TextChanged(object sender, EventArgs e)
        {
            lvwListTeacher.Items.Clear();
            string query = "SELECT * FROM Teacher_Info WHERE LastName='"+txtSearchLast.Text+"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListTeacher.Items.Add(dr.GetValue(0).ToString());
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
