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
    public partial class AuditTrail : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcDataReader dr;
        public ListViewItem list = new ListViewItem();
        string uID, loginID;

        public AuditTrail()
        {
            InitializeComponent();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        void viewcolor()
        {
            foreach (ListViewItem item in lvwAudit.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.LightGray;
                }
            }
        }

        void load()
        {
            lvwAudit.Items.Clear();
            string query = "SELECT * FROM tbl_AuditTrail";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list = lvwAudit.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
            }
            dr.Close();
            con.Close();
            viewcolor();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lvwAudit.Items.Clear();
            string query = "SELECT * FROM tbl_AuditTrail where Username like '" + txtSearch.Text + "%'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list = lvwAudit.Items.Add(dr.GetValue(0).ToString());
                list.SubItems.Add(dr.GetValue(1).ToString());
                list.SubItems.Add(dr.GetValue(2).ToString());
                list.SubItems.Add(dr.GetValue(3).ToString());
                list.SubItems.Add(dr.GetValue(4).ToString());
            }
            dr.Close();
            con.Close();
            viewcolor();
        }

        private void AuditTrail_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
