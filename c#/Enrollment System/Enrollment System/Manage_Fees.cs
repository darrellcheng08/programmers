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
    public partial class Manage_Fees : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        public Manage_Fees()
        {
            InitializeComponent();
        }

        void loadAll()
        {
            try
            {
                cmd = new OdbcCommand("Select FeeID  from tbl_Fee", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["FeeID"].ToString();
                    if (strid == "")
                    {
                        txtFeeID.Text = "0000" + 1;
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["FeeID"]) + 1;
                        txtFeeID.Text = "0000" + myID.ToString();
                    }
                }
                dr.Close();
                con.Close();

                string query = "SELECT * FROM year_level";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbYRLevel.Items.Add(dr.GetValue(1).ToString());
                }
                dr.Close();
                con.Close();

                lvwListFees.Items.Clear();
                query = "select * from tbl_Fee ORDER BY FeeName";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                ListViewItem list = new ListViewItem();

                list = lvwListFees.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
                list.SubItems.Add(dr.GetBoolean(5).ToString());
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
            txtFeeName.Text = "";
            txtDescription.Text = "";
            txtAmount.Text = "";
            cmbYRLevel.Text = "";
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
                    loadAll();
                    reset();
                    lockcontrol();
                }
                if (txtFeeID.Text == "")
                {
                    MessageBox.Show("Fee ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeeID.Focus();
                    return;
                }
                else if (txtFeeName.Text == "")
                {
                    MessageBox.Show("Fee Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeeName.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else if (txtAmount.Text == "")
                {
                    MessageBox.Show("Amount CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }
                else if (cmbYRLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbYRLevel.Focus();
                    return;
                }
                else
                {
                    string sql = "Select * from tbl_Fee where FeeName like '" + txtFeeName.Text + "'";
                    cmd = new OdbcCommand(sql, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Fee Name you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFeeName.Text = "";
                        txtFeeName.Focus();
                        dr.Close();
                        con.Close();
                        return;
                    }

                    cmd = new OdbcCommand("INSERT INTO tbl_Fee(FeeId,FeeName,Description,Amount,YearLevel,DateCreated) VALUES ('" + txtFeeID.Text + "','" + txtFeeName.Text + "','" + txtDescription.Text + "','" + txtAmount.Text + "','" + cmbYRLevel.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
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
                if (txtFeeID.Text == "")
                {
                    MessageBox.Show("Fee ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeeID.Focus();
                    return;
                }
                else if (txtFeeName.Text == "")
                {
                    MessageBox.Show("Fee Name CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFeeName.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else if (txtAmount.Text == "")
                {
                    MessageBox.Show("Amount CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }
                else if (cmbYRLevel.Text == "")
                {
                    MessageBox.Show("Year Level CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbYRLevel.Focus();
                    return;
                }
                else
                {
                    string sql = "Select * from tbl_Fee where FeeName like '" + txtFeeName.Text + "'";
                    cmd = new OdbcCommand(sql, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Fee Name you've input is already used, try another one", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFeeName.Text = "";
                        txtFeeName.Focus();
                        dr.Close();
                        con.Close();
                        return;
                    }

                    cmd = new OdbcCommand("UPDATE tbl_Fee SET FeeName='" + txtFeeName.Text + "',Description='" + txtDescription.Text + "',Amount='" + txtAmount.Text + "',YearLevel='" + cmbYRLevel.Text + "' WHERE FeeID='" + txtFeeID.Text + "'", con);
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

                    cmd = new OdbcCommand("DELETE FROM tbl_Fee WHERE FeeID='" + txtFeeID.Text + "'", con);
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

        private void txtSearchLast_TextChanged(object sender, EventArgs e)
        {
            lvwListFees.Items.Clear();
           string query = "select * from tbl_Fee Where FeeName like '"+ txtSearchLast.Text +"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListFees.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void Manage_Fees_Load(object sender, EventArgs e)
        {
            loadAll();
            lockcontrol();
        }

        private void lvwListFees_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFeeID.Text = lvwListFees.FocusedItem.SubItems[0].Text;
            txtFeeName.Text = lvwListFees.FocusedItem.SubItems[1].Text;
            txtDescription.Text = lvwListFees.FocusedItem.SubItems[2].Text;
            txtAmount.Text = lvwListFees.FocusedItem.SubItems[3].Text;
            cmbYRLevel.Text = lvwListFees.FocusedItem.SubItems[4].Text;
            unlock();
        }
    }
}
