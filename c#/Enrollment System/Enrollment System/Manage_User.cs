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
    public partial class Manage_User : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcDataReader dr;
        ListViewItem list = new ListViewItem();
        string text, passchar = "";

        public Manage_User()
        {
            InitializeComponent();
        }

        void listviewcolor()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = Color.White;
                else
                    item.BackColor = Color.LightGray;
            }
        }

        void getUser()
        {
            string sql = "select * from admin_login";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list = listView1.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                text = dr.GetValue(3).ToString();

                for (int x = 0; x < text.Length; x++)
                {
                    passchar += "•";
                }
                list.SubItems.Add(passchar);
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                passchar = "";
            }
            dr.Read();
            dr.Close();
            con.Close();
        }

        void clear()
        {
            txtName.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
            cboPrivilege.Text = "";
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnNewSave.Text == "Save")
                {
                    if (txtName.Text == "" || txtPass.Text == "" || txtUser.Text == "")
                    {
                        MessageBox.Show("Missing required field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql = "Select * from admin_login where username like '" + txtUser.Text + "'";
                    cmd = new OdbcCommand(sql, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Username you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Text = "";
                        txtUser.Focus();
                        return;
                    }
                    dr.Close();
                    con.Close();

                    sql = @"INSERT INTO admin_login(username,privilege,password,accountname) VALUES('" + txtUser.Text + "','" + cboPrivilege.Text + "','" + txtPass.Text + "','" + txtName.Text + "')";
                    cmd = new OdbcCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //sql = @"INSERT INTO tbl_Admin VALUES(@username,@password,@privilege,@accesscode,@acountname)";
                    //cm = new OleDbCommand(sql, cn);
                    //cm.Parameters.AddWithValue("@username", txtUser.Text);
                    //cm.Parameters.AddWithValue("@password", txtPass.Text);
                    //cm.Parameters.AddWithValue("@privilege", cboPrivilege.Text);
                    //cm.Parameters.AddWithValue("@accesscode", reg);
                    //cm.Parameters.AddWithValue("@acountname", txtName.Text);
                    //cm.ExecuteNonQuery();
                    //  MessageBox.Show("Successfuly added to the list!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MessageBox.Show("New user has been successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    getUser();
                }
                else
                {
                    clear();
                    btnNewSave.Text = "Save";
                    txtName.Enabled = true;
                    txtUser.Enabled = true;
                    txtPass.Enabled = true;
                    cboPrivilege.Enabled = true;
                    btnEdit.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * from admin_login where username like '" + txtUser.Text + "'";
                cmd = new OdbcCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Username you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = "";
                    txtUser.Focus();
                    dr.Close();
                    con.Close();
                    return;
                }

                sql = @"UPDATE admin_login SET username = '" + txtUser.Text + "',privilege ='" + cboPrivilege.Text + "',accountname = '" + txtName.Text + "' where uID like '" + listView1.FocusedItem.Text + "'";
                cmd = new OdbcCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully update!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
                getUser();
                clear();
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

                if (cboPrivilege.Text == "admin")
                {
                    MessageBox.Show("Admin Account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string sql = @"Delete from admin_login where uID like '" + listView1.FocusedItem.Text + "'";
                    cmd = new OdbcCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Delete!", "Enrollment Sytem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    getUser();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNewSave.Text = "New";
            txtName.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            cboPrivilege.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnNewSave.Enabled = true;
            panel3.Visible = false;
            btnEdit.Enabled = false;
            pictureBox1.Visible = true;
            txtName.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            //this.Close();
            //Menu men = new Menu();
            // men.Show();
        }

        private void Manage_User_Load(object sender, EventArgs e)
        {
            getUser();
            listviewcolor();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNewSave.Text = "New";
            txtPass.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnEdit.Enabled = true;
            txtName.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            cboPrivilege.Enabled = true;
            //  txtUser.Text = listView1.FocusedItem.Text;
            txtUser.Text = listView1.FocusedItem.SubItems[2].Text;
            txtPass.Text = listView1.FocusedItem.SubItems[3].Text;
            txtName.Text = listView1.FocusedItem.SubItems[1].Text;
            cboPrivilege.Text = listView1.FocusedItem.SubItems[4].Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pictureBox1.Visible = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtPassOld.Text == "")
                {
                    MessageBox.Show("Old Password CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassOld.Focus();
                    return;
                }
                else if (txtPassNew.Text == "")
                {
                    MessageBox.Show("New Password CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassNew.Focus();
                    return;
                }

                else if (txtPassConfirm.Text == "")
                {
                    MessageBox.Show("User Type CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassConfirm.Focus();
                    return;

                }
                else if (txtPassNew.Text != txtPassConfirm.Text)
                {
                    MessageBox.Show("The old and new password inputted didn't matched", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtPassOld.Text == txtPassNew.Text)
                {
                    MessageBox.Show("Password is same..Re-enter new password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassNew.Text = "";
                    txtPassConfirm.Text = "";
                    txtPassNew.Focus();
                    return;
                }

                string sql = @"UPDATE admin_login SET password = '" + txtPassConfirm.Text + "' where uID like '" + listView1.FocusedItem.Text + "'";
                cmd = new OdbcCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password successfully change", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel3.Visible = false;
                pictureBox1.Visible = true;
                btnCancel_Click(sender, e);
                listView1.Items.Clear();
                getUser();
                txtPassOld.Text = "";
                txtPassNew.Text = "";
                txtPassConfirm.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pictureBox1.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            passchar = "";

            listView1.Items.Clear();
            string sql = "select * from admin_login where Username like '" + txtSearch.Text + "%'";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list = listView1.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                text = dr.GetValue(3).ToString();

                for (int x = 0; x < text.Length; x++)
                {
                    passchar += "•";
                }
                list.SubItems.Add(passchar);
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                passchar = "";
            }
            dr.Read();
            con.Close();
        }
    }
}
