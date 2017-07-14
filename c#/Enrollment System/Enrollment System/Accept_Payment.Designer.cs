namespace Enrollment_System
{
    partial class Accept_Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clhAmout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPayHistory = new System.Windows.Forms.ListView();
            this.clmno1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPayAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAmtReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPaymentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCheque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBankNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFeename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwFees = new System.Windows.Forms.ListView();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblFeeTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.btnSaveAD = new System.Windows.Forms.Button();
            this.rdbCheque = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudId = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.btnStudID = new System.Windows.Forms.Button();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // clhAmout
            // 
            this.clhAmout.Text = "Amount";
            this.clhAmout.Width = 160;
            // 
            // lvwPayHistory
            // 
            this.lvwPayHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmno1,
            this.clmdate,
            this.clmPayAmount,
            this.clmChange,
            this.clmAmtReceived,
            this.clmPaymentType,
            this.clmCheque,
            this.clmBankNo,
            this.clmOR});
            this.lvwPayHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPayHistory.FullRowSelect = true;
            this.lvwPayHistory.GridLines = true;
            this.lvwPayHistory.Location = new System.Drawing.Point(282, 327);
            this.lvwPayHistory.Name = "lvwPayHistory";
            this.lvwPayHistory.Size = new System.Drawing.Size(455, 181);
            this.lvwPayHistory.TabIndex = 51;
            this.lvwPayHistory.UseCompatibleStateImageBehavior = false;
            this.lvwPayHistory.View = System.Windows.Forms.View.Details;
            // 
            // clmno1
            // 
            this.clmno1.Text = "No.";
            this.clmno1.Width = 40;
            // 
            // clmdate
            // 
            this.clmdate.Text = "Date";
            this.clmdate.Width = 150;
            // 
            // clmPayAmount
            // 
            this.clmPayAmount.Text = "Payment Amount";
            this.clmPayAmount.Width = 150;
            // 
            // clmChange
            // 
            this.clmChange.Text = "Change";
            this.clmChange.Width = 120;
            // 
            // clmAmtReceived
            // 
            this.clmAmtReceived.Text = "Amount Received";
            this.clmAmtReceived.Width = 150;
            // 
            // clmPaymentType
            // 
            this.clmPaymentType.Text = "Payment Type";
            this.clmPaymentType.Width = 200;
            // 
            // clmCheque
            // 
            this.clmCheque.Text = "Cheque No";
            this.clmCheque.Width = 150;
            // 
            // clmBankNo
            // 
            this.clmBankNo.Text = "Bank No";
            this.clmBankNo.Width = 100;
            // 
            // clmOR
            // 
            this.clmOR.Text = "OR";
            this.clmOR.Width = 150;
            // 
            // clhFeename
            // 
            this.clhFeename.Text = "Fee Name";
            this.clhFeename.Width = 250;
            // 
            // clmNo
            // 
            this.clmNo.Text = "NO.";
            this.clmNo.Width = 40;
            // 
            // lvwFees
            // 
            this.lvwFees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNo,
            this.clhFeename,
            this.clhAmout});
            this.lvwFees.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFees.FullRowSelect = true;
            this.lvwFees.GridLines = true;
            this.lvwFees.Location = new System.Drawing.Point(282, 120);
            this.lvwFees.Name = "lvwFees";
            this.lvwFees.Size = new System.Drawing.Size(455, 178);
            this.lvwFees.TabIndex = 50;
            this.lvwFees.UseCompatibleStateImageBehavior = false;
            this.lvwFees.View = System.Windows.Forms.View.Details;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Red;
            this.lblClassName.Location = new System.Drawing.Point(625, 86);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(17, 24);
            this.lblClassName.TabIndex = 49;
            this.lblClassName.Text = "-";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.ForeColor = System.Drawing.Color.Red;
            this.lblYearLevel.Location = new System.Drawing.Point(615, 66);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(17, 24);
            this.lblYearLevel.TabIndex = 48;
            this.lblYearLevel.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(542, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = "Class Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Location = new System.Drawing.Point(-3, -11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 57);
            this.panel3.TabIndex = 58;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accept Payment";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(690, 510);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 20);
            this.label21.TabIndex = 57;
            this.label21.Text = "0.00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(558, 512);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 15);
            this.label22.TabIndex = 56;
            this.label22.Text = "TOTAL:";
            // 
            // lblFeeTotal
            // 
            this.lblFeeTotal.AutoSize = true;
            this.lblFeeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblFeeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeTotal.ForeColor = System.Drawing.Color.Red;
            this.lblFeeTotal.Location = new System.Drawing.Point(689, 302);
            this.lblFeeTotal.Name = "lblFeeTotal";
            this.lblFeeTotal.Size = new System.Drawing.Size(44, 20);
            this.lblFeeTotal.TabIndex = 55;
            this.lblFeeTotal.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(558, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 15);
            this.label19.TabIndex = 54;
            this.label19.Text = "TOTAL:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(279, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 18);
            this.label18.TabIndex = 53;
            this.label18.Text = "Payment History";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(279, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 18);
            this.label17.TabIndex = 52;
            this.label17.Text = "Fees";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(542, 70);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(78, 15);
            this.labe.TabIndex = 46;
            this.labe.Text = "Year Level:";
            // 
            // btnSaveAD
            // 
            this.btnSaveAD.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAD.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAD.Location = new System.Drawing.Point(7, 280);
            this.btnSaveAD.Name = "btnSaveAD";
            this.btnSaveAD.Size = new System.Drawing.Size(234, 46);
            this.btnSaveAD.TabIndex = 37;
            this.btnSaveAD.Text = "Save";
            this.btnSaveAD.UseVisualStyleBackColor = false;
            // 
            // rdbCheque
            // 
            this.rdbCheque.AutoSize = true;
            this.rdbCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCheque.Location = new System.Drawing.Point(129, 19);
            this.rdbCheque.Name = "rdbCheque";
            this.rdbCheque.Size = new System.Drawing.Size(74, 19);
            this.rdbCheque.TabIndex = 7;
            this.rdbCheque.TabStop = true;
            this.rdbCheque.Text = "Cheque";
            this.rdbCheque.UseVisualStyleBackColor = true;
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCash.Location = new System.Drawing.Point(55, 19);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(57, 19);
            this.rdbCash.TabIndex = 6;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Cash";
            this.rdbCash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Cheque No:";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(97, 74);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(145, 21);
            this.txtBank.TabIndex = 34;
            this.txtBank.Text = "-";
            this.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Bank No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(279, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "School Year";
            // 
            // txtCheque
            // 
            this.txtCheque.Location = new System.Drawing.Point(96, 48);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(145, 21);
            this.txtCheque.TabIndex = 35;
            this.txtCheque.Text = "-";
            this.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBalance.Location = new System.Drawing.Point(192, 108);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 24);
            this.lblBalance.TabIndex = 36;
            this.lblBalance.Text = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStudName);
            this.groupBox2.Controls.Add(this.txtStudID);
            this.groupBox2.Controls.Add(this.btnStudID);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lblOR);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblStudId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 476);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveAD);
            this.groupBox3.Controls.Add(this.rdbCheque);
            this.groupBox3.Controls.Add(this.rdbCash);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCheque);
            this.groupBox3.Controls.Add(this.txtBank);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblBalance);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtChange);
            this.groupBox3.Location = new System.Drawing.Point(7, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 335);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(71, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 2);
            this.panel2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Payment/Cheque Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Red;
            this.txtAmount.Location = new System.Drawing.Point(6, 169);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(236, 47);
            this.txtAmount.TabIndex = 29;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Change:";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Red;
            this.txtChange.Location = new System.Drawing.Point(6, 244);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(236, 29);
            this.txtChange.TabIndex = 27;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 2);
            this.panel1.TabIndex = 29;
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.ForeColor = System.Drawing.Color.Red;
            this.lblOR.Location = new System.Drawing.Point(40, 106);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(47, 15);
            this.lblOR.TabIndex = 28;
            this.lblOR.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "OR:";
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(11, 22);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(129, 15);
            this.lblStudId.TabIndex = 5;
            this.lblStudId.Text = "Student ID Number";
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Image = global::Enrollment_System.Properties.Resources.close;
            this.button6.Location = new System.Drawing.Point(710, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 28);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Enrollment_System.Properties.Resources.images__5_1;
            this.pictureBox2.Location = new System.Drawing.Point(14, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 41);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(365, 63);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(171, 29);
            this.cmbSchoolYear.TabIndex = 59;
            // 
            // txtStudID
            // 
            this.txtStudID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStudID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudID.Location = new System.Drawing.Point(13, 39);
            this.txtStudID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(216, 27);
            this.txtStudID.TabIndex = 61;
            this.txtStudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudID
            // 
            this.btnStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudID.Location = new System.Drawing.Point(228, 38);
            this.btnStudID.Name = "btnStudID";
            this.btnStudID.Size = new System.Drawing.Size(28, 29);
            this.btnStudID.TabIndex = 60;
            this.btnStudID.Text = "...";
            this.btnStudID.UseVisualStyleBackColor = true;
            // 
            // txtStudName
            // 
            this.txtStudName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStudName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudName.Location = new System.Drawing.Point(13, 70);
            this.txtStudName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(242, 27);
            this.txtStudName.TabIndex = 62;
            this.txtStudName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Accept_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(744, 533);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.lvwPayHistory);
            this.Controls.Add(this.lvwFees);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblFeeTotal);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Name = "Accept_Payment";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader clhAmout;
        private System.Windows.Forms.ListView lvwPayHistory;
        private System.Windows.Forms.ColumnHeader clmno1;
        private System.Windows.Forms.ColumnHeader clmdate;
        private System.Windows.Forms.ColumnHeader clmPayAmount;
        private System.Windows.Forms.ColumnHeader clmChange;
        private System.Windows.Forms.ColumnHeader clmAmtReceived;
        private System.Windows.Forms.ColumnHeader clmPaymentType;
        private System.Windows.Forms.ColumnHeader clmCheque;
        private System.Windows.Forms.ColumnHeader clmBankNo;
        private System.Windows.Forms.ColumnHeader clmOR;
        private System.Windows.Forms.ColumnHeader clhFeename;
        private System.Windows.Forms.ColumnHeader clmNo;
        private System.Windows.Forms.ListView lvwFees;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblFeeTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Button btnSaveAD;
        private System.Windows.Forms.RadioButton rdbCheque;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        internal System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.Button btnStudID;
        internal System.Windows.Forms.TextBox txtStudName;
    }
}

