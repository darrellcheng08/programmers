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
    public partial class Search_Teacher_Encode_Grade : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();
        OdbcDataReader dr;
        ListViewItem list = new ListViewItem();

        Encoding_Of_Grades gawas;
        public string Teacherid, TeacherName;

        public Search_Teacher_Encode_Grade(Encoding_Of_Grades gawas)
        {
            InitializeComponent();
            this.gawas = gawas;
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

        private void lvwListStudTeacher_DoubleClick(object sender, EventArgs e)
        {
            Teacherid = lvwListStudTeacher.FocusedItem.SubItems[0].Text;
            TeacherName = lvwListStudTeacher.FocusedItem.SubItems[1].Text;
            gawas.SearchTeacherName(Teacherid, TeacherName);
            this.Close();
        }

        private void txtSearchLast_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from tbl_advisory where TeacherName like '" + txtSearchLast.Text + "%'";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list = lvwListStudTeacher.Items.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
            }
            dr.Close();
            con.Close();
        }

        private void Search_Teacher_Encode_Grade_Load(object sender, EventArgs e)
        {
            txtSearchLast_TextChanged(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
