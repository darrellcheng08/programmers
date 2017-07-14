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
    public partial class Main_Form : Form
    {
        OdbcConnection con = new OdbcConnection("Driver={MySQL ODBC 3.51 Driver};SERVER=localhost;USER=root;PASSWORD=sa; DB=Enrollment_system;");
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataAdapter da = new OdbcDataAdapter();
        OdbcDataReader dr;
        public string uID, Username, accountname, loginDate, logoutdate, logID;
        Login log = new Login();

        public Main_Form()
        {
            InitializeComponent();
        }

        public void auditrail(string ID, string action)
        {
            string query = "select Username from admin_login where uID='" + ID + "'";
            cmd = new OdbcCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Username = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.Close();

            string querys = "select AccountName from admin_login where uID='" + ID + "'";
            cmd = new OdbcCommand(querys, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                accountname = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.Close();

            string sqls = "insert into tbl_auditTrail(uID,UserName,AccountName,actionmade,datemade) values('" + ID + "','" + Username + "','" + accountname + "','" + action + "','" + DateTime.Now.ToString() + "')";
            cmd = new OdbcCommand(sqls, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void dawat(string ID, string loginD)
        {
            uID = ID;
            loginDate = loginD;

            string sql = "select * from tbl_logtrail where uID like '" + uID + "' and loginDate like '" + loginDate + "'";
            cmd = new OdbcCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                logID = dr.GetValue(5).ToString();
            }
            dr.Close();
            con.Close();
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.White;
            pnlColor.Visible = true;
            pnlColor.BackColor = Color.White;
            pnlRegistrar.Visible = false;
            pnlAdmin.Visible = false;
            pnlCashier.Visible = false;
            pnlEnrollment.Visible = false;
            pnlReport.Visible = false;
            pnlUtilities.Visible = false;
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            if (pnlBack.Visible == true)
            {
                pnlBack.Visible = false;
            }
            else
            {
                pnlBack.Visible = true;
            }
        }

        private void btnEnrollment_MouseEnter(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Lime;
            btnEnrollment.BackColor = Color.Lime;

            pnlEnrollment.Visible = true;
            pnlColor.Visible = true;
            pnlAdmin.Visible = false;
            pnlRegistrar.Visible = false;
            pnlCashier.Visible = false;
            pnlReport.Visible = false;
            pnlUtilities.Visible = false;
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Orange;
            btnRegistrar.BackColor = Color.Orange;

            pnlAdmin.Visible = false;
            pnlRegistrar.Visible = true;
            pnlCashier.Visible = false;
            pnlEnrollment.Visible = false;
            pnlReport.Visible = false;
            pnlUtilities.Visible = false;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = SystemColors.Control;
        }

        private void btnEnrollment_MouseLeave(object sender, EventArgs e)
        {
            btnEnrollment.BackColor = SystemColors.Control;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = SystemColors.Control;
        }

        private void btnCashier_MouseEnter(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Cyan;
            btnCashier.BackColor = Color.Cyan;

            pnlAdmin.Visible = false;
            pnlRegistrar.Visible = false;
            pnlCashier.Visible = true;
            pnlEnrollment.Visible = false;
            pnlReport.Visible = false;
            pnlReport.Visible = false;
            pnlUtilities.Visible = false;
        }

        private void btnCashier_MouseLeave(object sender, EventArgs e)
        {
            btnCashier.BackColor = SystemColors.Control;
        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.BlueViolet; ;
            btnReport.BackColor = Color.BlueViolet;

            pnlAdmin.Visible = false;
            pnlRegistrar.Visible = false;
            pnlCashier.Visible = false;
            pnlEnrollment.Visible = false;
            pnlReport.Visible = true;
            pnlUtilities.Visible = false;
        }

        private void btnAdminis_MouseEnter(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Yellow;
            btnAdminis.BackColor = Color.Yellow;

            pnlAdmin.Visible = true;
            pnlRegistrar.Visible = false;
            pnlCashier.Visible = false;
            pnlEnrollment.Visible = false;
            pnlReport.Visible = false;
            pnlUtilities.Visible = false;
        }

        private void btnUtilities_MouseEnter(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Silver;
            btnUtilities.BackColor = Color.Silver;

            pnlAdmin.Visible = false;
            pnlRegistrar.Visible = false;
            pnlCashier.Visible = false;
            pnlEnrollment.Visible = false;
            pnlReport.Visible = false;
            pnlUtilities.Visible = true;
        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            btnReport.BackColor = SystemColors.Control;
        }

        private void btnAdminis_MouseLeave(object sender, EventArgs e)
        {
            btnAdminis.BackColor = SystemColors.Control;
        }

        private void btnUtilities_MouseLeave(object sender, EventArgs e)
        {
            btnUtilities.BackColor = SystemColors.Control;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnListNewStud_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            List_New_Student listnew = new List_New_Student();
            listnew.ShowDialog();
            auditrail(uID, "The List of New Student form was display");
        }

        private void btnManageFees_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Manage_Fees fees = new Manage_Fees();
            fees.ShowDialog();
            auditrail(uID, "The Managing of Fees form was display");
        }

        private void btnAcceptPay_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Accept_Payment accpay = new Accept_Payment();
            accpay.ShowDialog();
            auditrail(uID, "The Accept of Payment form was display");
        }

        private void btnStudAccount_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Student_Ledger_Account studLedger = new Student_Ledger_Account();
            studLedger.ShowDialog();
            auditrail(uID, "The Student Ledger Account form was display");
        }

        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Payment_List paylist = new Payment_List();
            paylist.ShowDialog();
            auditrail(uID, "The List of Payment form was display");
        }

        private void btnbalances_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Collectibles_And_Balances balances = new Collectibles_And_Balances();
            balances.ShowDialog();
            auditrail(uID, "The Collectibles and Balances form was display");
        }

        private void btnManageSec_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            Section sec = new Section();
            sec.ShowDialog();
            auditrail(uID, "The Section under the maintenance form was display");
        }

        private void btnManageYRLevel_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            YearLevel yr = new YearLevel();
            yr.ShowDialog();
            auditrail(uID, "The Year Level under the maintenance form was display");
        }

        private void btnManageSchyear_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            SchoolYear schoolYR = new SchoolYear();
            schoolYR.ShowDialog();
            auditrail(uID, "The School Year under the maintenance form was display");
        }

        private void btnsetActive_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            Set_Active active = new Set_Active();
            active.ShowDialog();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            Room rm = new Room();
            rm.ShowDialog();
            auditrail(uID, "The Room under the maintenance form was display");
        }

        private void btnManageSub_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            Subject sb = new Subject();
            sb.ShowDialog();
            auditrail(uID, "The Subject under the maintenance form was display");
        }

        private void btnManageTeach_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            Teachers teach = new Teachers();
            teach.ShowDialog();
            auditrail(uID, "Managing Teacher under the maintenance form was display");
        }

        private void btnSetAdvisory_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            Class_Advisory advisory = new Class_Advisory();
            advisory.ShowDialog();
            auditrail(uID, "The Class Advisory under the maintenance form was display");
        }

        private void btnManageTeachSub_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            AddTeacher_Subject teachsub = new AddTeacher_Subject();
            teachsub.ShowDialog();
            auditrail(uID, "Managing Teacher Subject under the maintenance form was display");
        }

        private void btnListTeacher_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            List_Teacher_Subject list = new List_Teacher_Subject();
            list.ShowDialog();
            auditrail(uID, "The List of Teacher Subject form was display");
        }

        private void btnLogTrail_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            Log_Trail logtrail = new Log_Trail();
            logtrail.ShowDialog();
        }

        private void btnAuditTrail_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            AuditTrail audit = new AuditTrail();
            audit.ShowDialog();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            Manage_User user = new Manage_User();
            user.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int strHour = Convert.ToInt32(DateTime.Now.Hour.ToString("00"));
            string strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " AM";
            if (strHour > 12)
            {
                strHour = strHour - 12;
                strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " PM";
            }
            statDate.Text = DateTime.Now.Date.ToLongDateString();
            statTime.Text = strTime;
        }

        private void btnNewEnroll_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            New_Enrollment newenroll = new New_Enrollment();
            newenroll.dawat(uID, logID);
            newenroll.ShowDialog();
            auditrail(uID, "The New Enrollment form was display");
        }

        private void btnViewEnroll_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            List_Of_Enrolled_Students list = new List_Of_Enrolled_Students();
            list.ShowDialog();
            auditrail(uID, "The List of Enrolled Student form was display");
        }

        private void btnMalePerclass_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID, logID);
            Male_Female_per_Class male = new Male_Female_per_Class();
            male.ShowDialog();
            auditrail(uID, "The Male/Female per Class form was display");
        }

        private void btnPopulationSy_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Population_Per_SY population = new Population_Per_SY();
            population.ShowDialog();
            auditrail(uID, "The Population per SY form was display");
        }

        private void btnManageStud_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Student_Profile_Entry studEntry = new Student_Profile_Entry();
            studEntry.ShowDialog();
            auditrail(uID, "The Student Profile form was display");
        }

        private void btnEcodeGrade_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Encoding_Of_Grades enGrade = new Encoding_Of_Grades();
            enGrade.ShowDialog();
            auditrail(uID, "The Encoding of Grades form was display");
        }

        private void btnviewStudGrade_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Student_Grades grades = new Student_Grades();
            grades.ShowDialog();
            auditrail(uID, "The View Students Grade form was display");
        }

        private void btnCredentialInfo_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Credencial_Info credential = new Credencial_Info();
            credential.ShowDialog();
            auditrail(uID, "The Credential Info form was display");
        }

        private void btnStudCredential_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Student_Credential studcred = new Student_Credential();
            studcred.ShowDialog();
            auditrail(uID, "The Student Credential form was display");
        }

        private void btnManageSched_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            dawat(uID,logID);
            Schedule sched = new Schedule();
            sched.ShowDialog();
            auditrail(uID, "The Managing of Schedule under the maintenance form was display");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Enrollment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "select logid from tbl_logtrail";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    logID = dr.GetValue(0).ToString();
                }
                dr.Close();
                con.Close();

                cmd = new OdbcCommand("update tbl_logtrail set logoutdate = '" + DateTime.Now + "' where logID = '" + logID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                log.Show();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
            Change_Password1 change = new Change_Password1();
            change.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Enrollment System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "select logid from tbl_logtrail";
                cmd = new OdbcCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    logID = dr.GetValue(0).ToString();
                }
                dr.Close();
                con.Close();

                cmd = new OdbcCommand("update tbl_logtrail set logoutdate = '" + DateTime.Now + "' where logID = '" + logID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                log.Show();
            }
        }

        private void Main_Form_Click(object sender, EventArgs e)
        {
            pnlBack.Visible = false;
        }
    }
}
