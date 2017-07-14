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
    public partial class Search_Teacher : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        ListViewItem list = new ListViewItem();

        Class_Advisory gawas;
        public string Teacherid, FirstName, MiddleName, LastName;

        public Search_Teacher(Class_Advisory gawas)
        {
            InitializeComponent();
            this.gawas = gawas;
        }

        void getUser()
        {
            try
            {
                lvwListStudEnroll.Items.Clear();
                string sql = "Select * from Teacher_Info where LastName like '" + txtSearchLast.Text + "%'";
                cmd = new OdbcCommand(sql, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list = lvwListStudEnroll.Items.Add(dr.GetValue(0).ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Search_Teacher_Load(object sender, EventArgs e)
        {
            getUser();
        }

        private void txtSearchLast_TextChanged(object sender, EventArgs e)
        {
            getUser();
        }

        private void lvwListStudEnroll_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Teacherid = lvwListStudEnroll.FocusedItem.SubItems[0].Text;
                FirstName = lvwListStudEnroll.FocusedItem.SubItems[1].Text;
                MiddleName = lvwListStudEnroll.FocusedItem.SubItems[2].Text;
                LastName = lvwListStudEnroll.FocusedItem.SubItems[3].Text;
                gawas.TeacherName(Teacherid, FirstName + " ", MiddleName, LastName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Teacherid = lvwListStudEnroll.FocusedItem.SubItems[0].Text;
                FirstName = lvwListStudEnroll.FocusedItem.SubItems[1].Text;
                MiddleName = lvwListStudEnroll.FocusedItem.SubItems[2].Text;
                LastName = lvwListStudEnroll.FocusedItem.SubItems[3].Text;
                gawas.TeacherName(Teacherid, FirstName + " ", MiddleName, LastName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
