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
    public partial class Change_Password1 : Form
    {
        string currentName = "";
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcDataReader dr;
        public ListViewItem list = new ListViewItem();
        string uID, loginID;

        public Change_Password1()
        {
            InitializeComponent();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }
        public Main_Form menu = new Main_Form();
        public void getUser()
        {

            string sql = "Select username from admin_login";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                currentName = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.Close();

            sql = "Select * from admin_login where uID like '" + uID + "'";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                uID = dr.GetValue(0).ToString();
                txtUser.Text = dr.GetValue(2).ToString();
                txtPass.Text = dr.GetValue(3).ToString();
                txtName.Text = dr.GetValue(1).ToString();
            }
            dr.Close();
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Width += 933;
            if (this.Width == 933)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Width += 6;
            if (this.Width == 479)
            {
                timer1.Stop();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtPassNew.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Password do not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassOld.Text == txtPassNew.Text)
            {
                MessageBox.Show("Password is same..Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassNew.Text = "";
                txtPassConfirm.Text = "";
                txtPassNew.Focus();
            }
            string sql = "update admin_login set password = '" + txtPassConfirm.Text + "' where uID like '" + uID + "'";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Password successfully change", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCancel_Click(sender, e);
            txtPassOld.Text = "";
            txtPassNew.Text = "";
            txtPassConfirm.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Width = 478;
            timer1.Stop();
        }

        private void lblChangeName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblChangeName.Text == "Save")
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Invalid input!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string sql1 = "update admin_login set Accountname = '" + txtName.Text + "' where uID like '" + uID + "'";
                cmd = new OdbcCommand(sql1, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Name successfully changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getUser();
                lblChangeName.Text = "Change";
                txtName.ReadOnly = true;
            }
            else
            {
                lblChangeName.Text = "Save";
                txtName.ReadOnly = false;
                currentName = txtName.Text;
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void lblChangeUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblChangeUser.Text == "Save")
            {
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Invalid input!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //------------------------------------
                string sql = "Select * from admin_login where username like '" + txtUser.Text + "'";
                cmd = new OdbcCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Username you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtUser.Focus();
                    dr.Close();
                    return;
                }
                dr.Close();
                con.Close();
                //-----------------------------------------
                string sql1 = "update admin_login set username = '" + txtUser.Text + "' where uID like '" + uID + "'";
                cmd = new OdbcCommand(sql1, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Username successfully change", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getUser();
                lblChangeUser.Text = "Change";
                txtUser.ReadOnly = true;
            }
            else
            {
                lblChangeUser.Text = "Save";
                txtUser.ReadOnly = false;
                currentName = txtUser.Text;
                txtUser.Text = "";
                txtUser.Focus();
            }
        }

        private void lblChangepass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
        }

        private void Change_Password1_Load(object sender, EventArgs e)
        {
            getUser();
        }
    }
}
