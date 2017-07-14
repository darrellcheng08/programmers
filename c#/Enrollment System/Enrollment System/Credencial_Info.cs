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
    public partial class Credencial_Info : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        public Credencial_Info()
        {
            InitializeComponent();
        }

        void reset()
        {
            txtCredential.Text = "";
            txtDesc.Text = "";
        }

        void loadAll()
        {
            try
            {
                cmd = new OdbcCommand("SELECT credentialID from tbl_credential", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["CredentialID"].ToString();
                    if (strid == "")
                    {
                        txtCreID.Text = "0000" + 1;
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["CredentialID"]) + 1;
                        txtCreID.Text = "0000" + myID.ToString();
                    }
                }
                dr.Close();
                con.Close();

                lvwListCredential.Items.Clear();
                string query = "SELECT * FROM tbl_Credential ORDER BY credential";
                con.Open();
                cmd = new OdbcCommand(query, con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ListViewItem list = new ListViewItem();

                    list = lvwListCredential.Items.Add(dr.GetValue(0).ToString());
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        bool mouseDown;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X + e.X) - offsetX, (Location.Y + e.Y) - offsetY);
            }
        }
        int offsetX;
        int offsetY;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
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
                    loadAll();
                    reset();
                    lockcontrol();
                }
                if (txtCreID.Text == "")
                {
                    MessageBox.Show("Credential ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCreID.Focus();
                    return;
                }
                else if (txtCredential.Text == "")
                {
                    MessageBox.Show("Credential CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCredential.Focus();
                    return;
                }
                else if (txtDesc.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesc.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * FROM tbl_Credential WHERE Credential = '"+txtCredential.Text+"'";
                    cmd = new OdbcCommand(query,con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while(dr.HasRows)
                    {
                        MessageBox.Show("This Credential " + dr[1].ToString() + " is already added", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCredential.Text = "";
                        txtCredential.Focus();
                        return;
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("INSERT INTO tbl_Credential(CredentialID,Credential,Description,DateCreated) VALUES ('" + txtCreID.Text + "','" + txtCredential.Text + "','" + txtDesc.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
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
                if (txtCreID.Text == "")
                {
                    MessageBox.Show("Credential ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCreID.Focus();
                    return;
                }
                else if (txtCredential.Text == "")
                {
                    MessageBox.Show("Credential CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCredential.Focus();
                    return;
                }
                else if (txtDesc.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesc.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * FROM tbl_Credential WHERE Credential = '" + txtCredential.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.HasRows)
                    {
                        MessageBox.Show("This Credential " + dr[1].ToString() + " is already in the list", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCredential.Text = "";
                        txtCredential.Focus();
                        return;
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("UPDATE tbl_Credential SET Credential='" + txtCredential.Text + "',Description='" + txtDesc.Text + "' WHERE CredentialID='" + txtCreID.Text + "'", con);
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
                    cmd = new OdbcCommand("DELETE FROM tbl_Credential WHERE CredentialID='" + txtCreID.Text + "'", con);
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

        private void Credencial_Info_Load(object sender, EventArgs e)
        {
            loadAll();
            lockcontrol();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lvwListCredential.Items.Clear();
            string query = "SELECT * FROM tbl_Credential where credential like '"+ txtSearch.Text +"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListCredential.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void lvwListCredential_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCreID.Text = lvwListCredential.FocusedItem.SubItems[0].Text;
            txtCredential.Text = lvwListCredential.FocusedItem.SubItems[1].Text;
            txtDesc.Text = lvwListCredential.FocusedItem.SubItems[2].Text;
            unlock();
        }
    }
}
