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
    public partial class Set_Active : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        public Set_Active()
        {
            InitializeComponent();
        }

        void SY()
        {
            string query = "Select SchoolYear from tbl_SchoolYear";
            cmd = new OdbcCommand(query,con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmbSchoolYear.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            con.Close();
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
                string query = "UPDATE tbl_SchoolYear set status='Active' Where SchoolYear ='" + cmbSchoolYear.Text + "'";
                cmd = new OdbcCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string sql = "update tbl_schoolyear set Status = 'Inactive' where SchoolYear <> '" + cmbSchoolYear.Text + "'";
                cmd = new OdbcCommand(sql,con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Year is Active", "Christian Kiddie Star Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Set_Active_Load(object sender, EventArgs e)
        {
            SY();
        }
    }
}
