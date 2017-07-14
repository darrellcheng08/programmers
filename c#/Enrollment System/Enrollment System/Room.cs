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
    public partial class Room : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        string uID, loginID;

        public Room()
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
                cmd = new OdbcCommand("select roomid from tbl_room", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["roomid"].ToString();
                    if (strid == "")
                    {
                        txtRoomID.Text = "0000" + "1";
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["roomid"]) + 1;
                        txtRoomID.Text = "0000" + myID.ToString();
                    }
                }
                dr.Close();
                con.Close();

                lvwListRoom.Items.Clear();
                string query = "SELECT * FROM tbl_room ORDER BY Room";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    ListViewItem list = new ListViewItem();

                    list = lvwListRoom.Items.Add(dr.GetValue(0).ToString());
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
            txtRoomCode.Text = "";
            txtDescription.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
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
                    lockcontrol();
                    reset();
                }
                if (txtRoomID.Text == "")
                {
                    MessageBox.Show("Room ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRoomID.Focus();
                    return;
                }
                else if (txtRoomCode.Text == "")
                {
                    MessageBox.Show("Room Code CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRoomCode.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * FROM tbl_Room WHERE Room = '" + txtRoomCode.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.HasRows)
                    {
                        MessageBox.Show("This Room Name " + dr[1].ToString() + " is already added,Please try another one!", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("INSERT INTO tbl_room(roomid,room,description,DateCreated) VALUES ('" + txtRoomID.Text + "','" + txtRoomCode.Text + "','" + txtDescription.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + "')", con);
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
                if (txtRoomID.Text == "")
                {
                    MessageBox.Show("Room ID CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRoomID.Focus();
                    return;
                }
                else if (txtRoomCode.Text == "")
                {
                    MessageBox.Show("Room Code CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRoomCode.Focus();
                    return;
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Description CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return;
                }
                else
                {
                    string query = "SELECT * FROM tbl_Room WHERE Room = '" + txtRoomCode.Text + "'";
                    cmd = new OdbcCommand(query, con);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.HasRows)
                    {
                        MessageBox.Show("This Room Name " + dr[1].ToString() + " is already added,Please try another one!", "Agape Christian School", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dr.Close();
                    con.Close();

                    cmd = new OdbcCommand("UPDATE tbl_room SET room='" + txtRoomCode.Text + "',Description='" + txtDescription.Text + "' WHERE roomid='" + txtRoomID.Text + "'", con);
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
                    cmd = new OdbcCommand("DELETE from tbl_room where roomid='" + txtRoomID.Text + "'", con);
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
            string query = "SELECT * FROM tbl_room where Room like '"+ txtSearchLast.Text +"%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();

                list = lvwListRoom.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            loadAll();
            lockcontrol();
        }

        private void lvwListRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomID.Text = lvwListRoom.FocusedItem.SubItems[0].Text;
            txtRoomCode.Text = lvwListRoom.FocusedItem.SubItems[1].Text;
            txtDescription.Text = lvwListRoom.FocusedItem.SubItems[2].Text;
            unlock();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
