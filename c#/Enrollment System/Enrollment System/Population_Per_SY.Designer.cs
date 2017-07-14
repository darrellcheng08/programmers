namespace Enrollment_System
{
    partial class Population_Per_SY
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clhYearLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSchoolYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSchoolYR = new System.Windows.Forms.ComboBox();
            this.lblTotalPO = new System.Windows.Forms.Label();
            this.txtTotalPO = new System.Windows.Forms.TextBox();
            this.lblSchoolYRPO = new System.Windows.Forms.Label();
            this.clhRecNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPopulationPO = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(-5, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 57);
            this.panel1.TabIndex = 26;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(64, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Population per SY";
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
            // clhYearLevel
            // 
            this.clhYearLevel.Text = "Year Level";
            this.clhYearLevel.Width = 140;
            // 
            // clhTotal
            // 
            this.clhTotal.Text = "Total";
            this.clhTotal.Width = 105;
            // 
            // clhSchoolYear
            // 
            this.clhSchoolYear.Text = "School Year";
            this.clhSchoolYear.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSchoolYR);
            this.groupBox2.Controls.Add(this.lblTotalPO);
            this.groupBox2.Controls.Add(this.txtTotalPO);
            this.groupBox2.Controls.Add(this.lblSchoolYRPO);
            this.groupBox2.Location = new System.Drawing.Point(9, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 68);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // cmbSchoolYR
            // 
            this.cmbSchoolYR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolYR.FormattingEnabled = true;
            this.cmbSchoolYR.Location = new System.Drawing.Point(18, 33);
            this.cmbSchoolYR.Name = "cmbSchoolYR";
            this.cmbSchoolYR.Size = new System.Drawing.Size(188, 29);
            this.cmbSchoolYR.TabIndex = 33;
            // 
            // lblTotalPO
            // 
            this.lblTotalPO.AutoSize = true;
            this.lblTotalPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPO.Location = new System.Drawing.Point(365, 33);
            this.lblTotalPO.Name = "lblTotalPO";
            this.lblTotalPO.Size = new System.Drawing.Size(43, 15);
            this.lblTotalPO.TabIndex = 31;
            this.lblTotalPO.Text = "Total:";
            // 
            // txtTotalPO
            // 
            this.txtTotalPO.Location = new System.Drawing.Point(411, 24);
            this.txtTotalPO.Multiline = true;
            this.txtTotalPO.Name = "txtTotalPO";
            this.txtTotalPO.Size = new System.Drawing.Size(70, 31);
            this.txtTotalPO.TabIndex = 30;
            this.txtTotalPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSchoolYRPO
            // 
            this.lblSchoolYRPO.AutoSize = true;
            this.lblSchoolYRPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolYRPO.Location = new System.Drawing.Point(15, 16);
            this.lblSchoolYRPO.Name = "lblSchoolYRPO";
            this.lblSchoolYRPO.Size = new System.Drawing.Size(88, 15);
            this.lblSchoolYRPO.TabIndex = 29;
            this.lblSchoolYRPO.Text = "School Year:";
            // 
            // clhRecNo
            // 
            this.clhRecNo.Text = "Record ID";
            this.clhRecNo.Width = 100;
            // 
            // lvwPopulationPO
            // 
            this.lvwPopulationPO.BackColor = System.Drawing.Color.White;
            this.lvwPopulationPO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhRecNo,
            this.clhSchoolYear,
            this.clhYearLevel,
            this.clhTotal});
            this.lvwPopulationPO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPopulationPO.FullRowSelect = true;
            this.lvwPopulationPO.GridLines = true;
            this.lvwPopulationPO.Location = new System.Drawing.Point(7, 18);
            this.lvwPopulationPO.Name = "lvwPopulationPO";
            this.lvwPopulationPO.Size = new System.Drawing.Size(477, 221);
            this.lvwPopulationPO.TabIndex = 6;
            this.lvwPopulationPO.UseCompatibleStateImageBehavior = false;
            this.lvwPopulationPO.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwPopulationPO);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 246);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Population_Details";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(9, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(423, 376);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 34);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // Population_Per_SY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(515, 416);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Population_Per_SY";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader clhYearLevel;
        private System.Windows.Forms.ColumnHeader clhTotal;
        private System.Windows.Forms.ColumnHeader clhSchoolYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalPO;
        private System.Windows.Forms.TextBox txtTotalPO;
        private System.Windows.Forms.Label lblSchoolYRPO;
        private System.Windows.Forms.ColumnHeader clhRecNo;
        private System.Windows.Forms.ListView lvwPopulationPO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbSchoolYR;
    }
}