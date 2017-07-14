namespace Enrollment_System
{
    partial class Student_Ledger_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Ledger_Account));
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFeeTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnprintledger = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStudID = new System.Windows.Forms.Button();
            this.lblStudId = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
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
            this.clhAmout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFeename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwFees = new System.Windows.Forms.ListView();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBalance.Location = new System.Drawing.Point(199, 196);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 24);
            this.lblBalance.TabIndex = 36;
            this.lblBalance.Text = "0.00";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.ForeColor = System.Drawing.Color.Red;
            this.lblYearLevel.Location = new System.Drawing.Point(615, 65);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(16, 22);
            this.lblYearLevel.TabIndex = 64;
            this.lblYearLevel.Text = "-";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPay.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPay.Location = new System.Drawing.Point(727, 498);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(48, 22);
            this.lblTotalPay.TabIndex = 73;
            this.lblTotalPay.Text = "0.00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Location = new System.Drawing.Point(-1, -11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 57);
            this.panel3.TabIndex = 58;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(756, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 28);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Ledger Account";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(78, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 2);
            this.panel2.TabIndex = 30;
            // 
            // lblFeeTotal
            // 
            this.lblFeeTotal.AutoSize = true;
            this.lblFeeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblFeeTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeTotal.ForeColor = System.Drawing.Color.Red;
            this.lblFeeTotal.Location = new System.Drawing.Point(728, 296);
            this.lblFeeTotal.Name = "lblFeeTotal";
            this.lblFeeTotal.Size = new System.Drawing.Size(48, 22);
            this.lblFeeTotal.TabIndex = 71;
            this.lblFeeTotal.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(550, 299);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 15);
            this.label19.TabIndex = 70;
            this.label19.Text = "TOTAL:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(279, 298);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 18);
            this.label18.TabIndex = 69;
            this.label18.Text = "Payment History";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(279, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 18);
            this.label17.TabIndex = 68;
            this.label17.Text = "Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Balance:";
            // 
            // btnprintledger
            // 
            this.btnprintledger.BackColor = System.Drawing.SystemColors.Control;
            this.btnprintledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintledger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintledger.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnprintledger.Location = new System.Drawing.Point(16, 134);
            this.btnprintledger.Name = "btnprintledger";
            this.btnprintledger.Size = new System.Drawing.Size(234, 46);
            this.btnprintledger.TabIndex = 37;
            this.btnprintledger.Text = "Print Ledger";
            this.btnprintledger.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(542, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 63;
            this.label14.Text = "Class Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(279, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 60;
            this.label12.Text = "School Year";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(550, 501);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 15);
            this.label22.TabIndex = 72;
            this.label22.Text = "TOTAL:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 2);
            this.panel1.TabIndex = 29;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(542, 68);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(78, 15);
            this.labe.TabIndex = 62;
            this.labe.Text = "Year Level:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStudID);
            this.groupBox2.Controls.Add(this.txtStudName);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.btnprintledger);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnStudID);
            this.groupBox2.Controls.Add(this.lblStudId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 437);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // btnStudID
            // 
            this.btnStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudID.Location = new System.Drawing.Point(223, 40);
            this.btnStudID.Name = "btnStudID";
            this.btnStudID.Size = new System.Drawing.Size(28, 29);
            this.btnStudID.TabIndex = 25;
            this.btnStudID.Text = "...";
            this.btnStudID.UseVisualStyleBackColor = true;
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(11, 23);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(129, 15);
            this.lblStudId.TabIndex = 5;
            this.lblStudId.Text = "Student ID Number";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Red;
            this.lblClassName.Location = new System.Drawing.Point(625, 86);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(16, 22);
            this.lblClassName.TabIndex = 65;
            this.lblClassName.Text = "-";
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
            this.lvwPayHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPayHistory.FullRowSelect = true;
            this.lvwPayHistory.GridLines = true;
            this.lvwPayHistory.Location = new System.Drawing.Point(282, 319);
            this.lvwPayHistory.Name = "lvwPayHistory";
            this.lvwPayHistory.Size = new System.Drawing.Size(497, 178);
            this.lvwPayHistory.TabIndex = 67;
            this.lvwPayHistory.UseCompatibleStateImageBehavior = false;
            this.lvwPayHistory.View = System.Windows.Forms.View.Details;
            // 
            // clmno1
            // 
            this.clmno1.Text = "No";
            this.clmno1.Width = 50;
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
            this.clmChange.Width = 150;
            // 
            // clmAmtReceived
            // 
            this.clmAmtReceived.Text = "Amount Received";
            this.clmAmtReceived.Width = 180;
            // 
            // clmPaymentType
            // 
            this.clmPaymentType.Text = "Payment Type";
            this.clmPaymentType.Width = 100;
            // 
            // clmCheque
            // 
            this.clmCheque.Text = "Cheque No";
            this.clmCheque.Width = 100;
            // 
            // clmBankNo
            // 
            this.clmBankNo.Text = "Bank No";
            this.clmBankNo.Width = 100;
            // 
            // clmOR
            // 
            this.clmOR.Text = "OR";
            this.clmOR.Width = 100;
            // 
            // clhAmout
            // 
            this.clhAmout.Text = "Amount";
            this.clhAmout.Width = 200;
            // 
            // clhFeename
            // 
            this.clhFeename.Text = "Fee Name";
            this.clhFeename.Width = 250;
            // 
            // clmNo
            // 
            this.clmNo.Text = "NO.";
            this.clmNo.Width = 50;
            // 
            // lvwFees
            // 
            this.lvwFees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNo,
            this.clhFeename,
            this.clhAmout});
            this.lvwFees.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFees.FullRowSelect = true;
            this.lvwFees.GridLines = true;
            this.lvwFees.Location = new System.Drawing.Point(282, 116);
            this.lvwFees.Name = "lvwFees";
            this.lvwFees.Size = new System.Drawing.Size(497, 178);
            this.lvwFees.TabIndex = 66;
            this.lvwFees.UseCompatibleStateImageBehavior = false;
            this.lvwFees.View = System.Windows.Forms.View.Details;
            // 
            // txtStudName
            // 
            this.txtStudName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStudName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudName.Location = new System.Drawing.Point(14, 72);
            this.txtStudName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(236, 27);
            this.txtStudName.TabIndex = 38;
            this.txtStudName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudID
            // 
            this.txtStudID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStudID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudID.Location = new System.Drawing.Point(14, 41);
            this.txtStudID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(210, 27);
            this.txtStudID.TabIndex = 39;
            this.txtStudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(365, 61);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(171, 29);
            this.cmbSchoolYear.TabIndex = 74;
            // 
            // Student_Ledger_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblFeeTotal);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lvwPayHistory);
            this.Controls.Add(this.lvwFees);
            this.Name = "Student_Ledger_Account";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFeeTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnprintledger;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStudID;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.Label lblClassName;
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
        private System.Windows.Forms.ColumnHeader clhAmout;
        private System.Windows.Forms.ColumnHeader clhFeename;
        private System.Windows.Forms.ColumnHeader clmNo;
        private System.Windows.Forms.ListView lvwFees;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
    }
}