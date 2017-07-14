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
    public partial class Change_Password : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcDataReader dr;

        string uID, loginID;

        public Change_Password()
        {
            InitializeComponent();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        void reset()
        {
            txtName.Text = "";
            txtUser.Text = "";
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtConPass.Text = "";
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                else if (txtUser.Text == "")
                {
                    MessageBox.Show("User Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                    return;
                }
                else if (txtOldPass.Text == "")
                {
                    MessageBox.Show("Old Password CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPass.Focus();
                    return;
                }
                else if (txtNewPass.Text == "")
                {
                    MessageBox.Show("New Password CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPass.Focus();
                    return;
                }
                else if (txtConPass.Text == "")
                {
                    MessageBox.Show("Confirm Password CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConPass.Focus();
                    return;
                }
                else if (txtNewPass.Text != txtConPass.Text)
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPass.Text = "";
                    txtOldPass.Text = "";
                    txtConPass.Text = "";
                    txtOldPass.Focus();
                    return;
                }
                else if (txtOldPass.Text == txtNewPass.Text)
                {
                    MessageBox.Show("Password is same..Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPass.Text = "";
                    txtConPass.Text = "";
                    txtNewPass.Focus();
                }
                else
                {
                   // string query = "SELECT * FROM admin_login where Username='" + txtUser.Text + "'";
                    //cmd = new OdbcCommand(query, con);
                    //dr = cmd.ExecuteReader();
                    //while (dr.HasRows)
                    //{
                        ///MessageBox.Show("This UserName " + dr[2].ToString() + " is already use, Try another one!", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //txtUser.Text = "";
                        //txtUser.Focus();
                        //return;
                    //}

                   string query = "Select * from admin_login where password='" + txtOldPass.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        string cs = @"UPDATE admin_login set AccountName='" + txtName.Text + "',Username='" + txtUser.Text + "',Password='" + txtNewPass.Text + "' where password like '" + txtOldPass.Text + "'";
                        cmd = new OdbcCommand(cs, con);
                        //con.Open();
                        cmd.ExecuteNonQuery();
                        //con.Close();
                        MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Password do not match, Please enter the correct Old Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOldPass.Text = "";
                        txtOldPass.Focus();
                        dr.Close();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
