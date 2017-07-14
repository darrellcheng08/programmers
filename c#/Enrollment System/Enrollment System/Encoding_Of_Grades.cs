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
    public partial class Encoding_Of_Grades : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        public int myID;

        public Encoding_Of_Grades()
        {
            InitializeComponent();
        }

        void loadAll()
        {
            string query = "SELECT * FROM tbl_SchoolYear Where Status='Active'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSchoolYear.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
            con.Close();

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

            query = "SELECT * FROM tbl_Subject";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSubject.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
            con.Close();
        }

        public void SearchTeacherName(string Teacherid, string TeacherName)
        {
            lblID.Text = Teacherid;
            txtTeacher.Text = TeacherName;
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

        private void btnTech_Click(object sender, EventArgs e)
        {
            Search_Teacher_Encode_Grade search = new Search_Teacher_Encode_Grade(this);
            search.ShowDialog();
        }

        private void Encoding_Of_Grades_Load(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
