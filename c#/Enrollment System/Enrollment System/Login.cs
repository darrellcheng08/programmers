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
    public partial class Login : Form
    {
        public OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        public OdbcCommand cmd = new OdbcCommand();
        public OdbcDataAdapter da = new OdbcDataAdapter();
        public OdbcDataReader dr;
        string accountname, uID , logindate;
        string username, password;
        
        public Login()
        {
            InitializeComponent();
        }

        public void getuID()
        {
            string query = "select * from admin_login where UserName like '" + txtUser.Text + "' and Password like '" + txtPass.Text + "'";
            cmd = new OdbcCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                uID = dr.GetValue(0).ToString();
            }
        }

        public void getloginDate()
        {
            string query = "select * from tbl_Logtrail uID='" + uID + "',Username='" + txtUser.Text + "'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                logindate = dr.GetValue(3).ToString();
            }
            dr.Close();
            con.Close();
        }
        public void AccountName()
        {
            string query = "select * from admin_login where UserName like '" + txtUser.Text + "' and Password like '" + txtPass.Text + "'";
            cmd = new OdbcCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                accountname = dr.GetValue(1).ToString();
            }
        }

        public void insertToLogtrail()
        {
            logindate = Convert.ToString(DateTime.Now);
            string query = "INSERT INTO tbl_logtrail(uID,Username,AccountName,logindate) VALUES ('" + uID + "','" + txtUser.Text + "','" + accountname + "','" + logindate + "')";
            cmd = new OdbcCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        bool mouseDown;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            offsetX = e.X;
            offsetY = e.Y;
            mouseDown = true;
        }
        int offsetX;
        int offsetY;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X + e.X) - offsetX, (Location.Y + e.Y) - offsetY);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("UserName CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                return;
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Password CAN NOT BE EMPTY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            else
            {
                Main_Form main = new Main_Form();
                username = txtUser.Text;
                password = txtPass.Text;
                cmd = new OdbcCommand("select * from admin_login where username like '" + txtUser.Text + "' and password like '" + txtPass.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    if (dr.GetValue(4).ToString() == "cashier")
                    {
                        main.btnAdminis.Visible = false;
                        main.btnRegistrar.Visible = false;
                        main.btnReport.Visible = false;
                        main.btnUtilities.Visible = false;
                        main.tsmAdministrative.Visible = false;
                        main.tsmRegistrar.Visible = false;
                        main.tsmReport.Visible = false;
                        main.tsmUser.Visible = false;
                        main.btnUtilities.Visible = false;
                        main.pnlBack.Size = new Size(391, 410);
                        main.pnlColor.Size = new Size(213, 392);
                        main.pnlCashier.Size = new Size(200, 380);
                        main.pnlEnrollment.Size = new Size(200, 380);
                        main.navigationPane.Size = new Size(151, 392);
                        main.lblUser.Text = txtUser.Text;
                    }
                    if (dr.GetValue(4).ToString() == "registrar")
                    {
                        main.btnAdminis.Visible = false;
                        main.btnReport.Visible = false;
                        main.btnUtilities.Visible = false;
                        main.btnCashier.Visible = false;
                        main.btnEnrollment.Visible = false;
                        main.tsmEnrollment.Visible = false;
                        main.tsmAdministrative.Visible = false;
                        main.tsmCashier.Visible = false;
                        main.tsmReport.Visible = false;
                        main.tsmUser.Visible = false;
                        main.pnlBack.Size = new Size(391, 500);
                        main.pnlColor.Size = new Size(213, 480);
                        main.navigationPane.Size = new Size(151, 480);
                        main.pnlRegistrar.Size = new Size(200, 470);
                        main.btnUtilities.Visible = false;
                        main.lblUser.Text = txtUser.Text;
                    }
                    MessageBox.Show("Welcome " + dr[1].ToString() + " \n Time&Date Login : " + DateTime.Now.ToString() + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getuID();
                    AccountName();
                    insertToLogtrail();
                    main.auditrail(uID, "Logged in successfully");
                    this.Hide();
                    main.lblUser.Text = txtUser.Text;
                    main.dawat(uID, logindate);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
                dr.Close();
                con.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?", "Agape Christian School", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?", "Agape Christian School", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Text = "Username";
            txtPass.Text = "Password";
            txtPass.PasswordChar = '\0';
            txtUser.ForeColor = Color.Gainsboro;
            txtPass.ForeColor = Color.Gainsboro;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '•';
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
