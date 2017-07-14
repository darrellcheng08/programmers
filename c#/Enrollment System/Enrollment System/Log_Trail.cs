using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enrollment_System
{
    public partial class Log_Trail : Form
    {
        //OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Darrell Cheng\Documents\Enrollment_Database.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd=new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;

        public ListViewItem list = new ListViewItem();
        string uID, loginID;

        public Log_Trail()
        {
            InitializeComponent();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        void listviewColor()
        {
            foreach (ListViewItem item in lvwListLogTrail.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = Color.White;
                else
                    item.BackColor = Color.LightBlue;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lvwListLogTrail.Items.Clear();
            string sql = "select * from tbl_logtrail where username like '" + txtSearch.Text + "%'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list = lvwListLogTrail.Items.Add(dr.GetValue(0).ToString()); // username
                list.SubItems.Add(dr.GetValue(1).ToString()); // account name
                list.SubItems.Add(dr.GetValue(2).ToString()); // login
                list.SubItems.Add(dr.GetValue(3).ToString()); // logout
                list.SubItems.Add(dr.GetValue(4).ToString()); // logout
            }
            dr.Close();
            con.Close();
            listviewColor();
        }

        private void Log_Trail_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }
    }
}
