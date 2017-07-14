namespace Enrollment_System
{
    partial class Encoding_Of_Grades
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
            this.txt2ndGrading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt1stgrading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtStudName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtstudID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwStudList = new System.Windows.Forms.ListView();
            this.txt3rdGrading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt4rthGrading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchEN = new System.Windows.Forms.TextBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblSubEN = new System.Windows.Forms.Label();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.lblClassNameEN = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnTech = new System.Windows.Forms.Button();
            this.lblSchoolYearEN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTechEN = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt2ndGrading
            // 
            this.txt2ndGrading.Text = "2nd Grading";
            this.txt2ndGrading.Width = 110;
            // 
            // txt1stgrading
            // 
            this.txt1stgrading.Text = "1st Grading";
            this.txt1stgrading.Width = 110;
            // 
            // txtStudName
            // 
            this.txtStudName.Text = "Student Name";
            this.txtStudName.Width = 220;
            // 
            // txtstudID
            // 
            this.txtstudID.Text = "Student ID";
            this.txtstudID.Width = 150;
            // 
            // lvwStudList
            // 
            this.lvwStudList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtstudID,
            this.txtStudName,
            this.txt1stgrading,
            this.txt2ndGrading,
            this.txt3rdGrading,
            this.txt4rthGrading,
            this.txtAverage,
            this.txtRemarks});
            this.lvwStudList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwStudList.FullRowSelect = true;
            this.lvwStudList.GridLines = true;
            this.lvwStudList.Location = new System.Drawing.Point(7, 166);
            this.lvwStudList.Name = "lvwStudList";
            this.lvwStudList.RightToLeftLayout = true;
            this.lvwStudList.Size = new System.Drawing.Size(814, 292);
            this.lvwStudList.TabIndex = 37;
            this.lvwStudList.UseCompatibleStateImageBehavior = false;
            this.lvwStudList.View = System.Windows.Forms.View.Details;
            // 
            // txt3rdGrading
            // 
            this.txt3rdGrading.Text = "3rd Grading";
            this.txt3rdGrading.Width = 110;
            // 
            // txt4rthGrading
            // 
            this.txt4rthGrading.Text = "4rth Grading";
            this.txt4rthGrading.Width = 110;
            // 
            // txtAverage
            // 
            this.txtAverage.Text = "Average";
            this.txtAverage.Width = 120;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Text = "Remarks";
            this.txtRemarks.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(-4, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 57);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(64, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoding Of Grades";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(7, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Double Click the Item to Edit Grades";
            // 
            // txtSearchEN
            // 
            this.txtSearchEN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEN.Location = new System.Drawing.Point(195, 128);
            this.txtSearchEN.Multiline = true;
            this.txtSearchEN.Name = "txtSearchEN";
            this.txtSearchEN.Size = new System.Drawing.Size(337, 31);
            this.txtSearchEN.TabIndex = 36;
            this.txtSearchEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(555, 32);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(161, 29);
            this.cmbSubject.TabIndex = 37;
            // 
            // cmbClassName
            // 
            this.cmbClassName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(369, 32);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(180, 29);
            this.cmbClassName.TabIndex = 38;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(726, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 47);
            this.btnGenerate.TabIndex = 32;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // txtTeacher
            // 
            this.txtTeacher.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacher.Location = new System.Drawing.Point(153, 34);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(183, 27);
            this.txtTeacher.TabIndex = 36;
            this.txtTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubEN
            // 
            this.lblSubEN.AutoSize = true;
            this.lblSubEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubEN.Location = new System.Drawing.Point(552, 16);
            this.lblSubEN.Name = "lblSubEN";
            this.lblSubEN.Size = new System.Drawing.Size(59, 15);
            this.lblSubEN.TabIndex = 31;
            this.lblSubEN.Text = "Subject:";
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(9, 32);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(136, 29);
            this.cmbSchoolYear.TabIndex = 35;
            // 
            // lblClassNameEN
            // 
            this.lblClassNameEN.AutoSize = true;
            this.lblClassNameEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassNameEN.Location = new System.Drawing.Point(366, 16);
            this.lblClassNameEN.Name = "lblClassNameEN";
            this.lblClassNameEN.Size = new System.Drawing.Size(88, 15);
            this.lblClassNameEN.TabIndex = 17;
            this.lblClassNameEN.Text = "Class Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(242, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "ID:";
            // 
            // btnTech
            // 
            this.btnTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTech.Location = new System.Drawing.Point(334, 33);
            this.btnTech.Name = "btnTech";
            this.btnTech.Size = new System.Drawing.Size(28, 29);
            this.btnTech.TabIndex = 22;
            this.btnTech.Text = "...";
            this.btnTech.UseVisualStyleBackColor = true;
            this.btnTech.Click += new System.EventHandler(this.btnTech_Click);
            // 
            // lblSchoolYearEN
            // 
            this.lblSchoolYearEN.AutoSize = true;
            this.lblSchoolYearEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolYearEN.Location = new System.Drawing.Point(6, 16);
            this.lblSchoolYearEN.Name = "lblSchoolYearEN";
            this.lblSchoolYearEN.Size = new System.Drawing.Size(88, 15);
            this.lblSchoolYearEN.TabIndex = 27;
            this.lblSchoolYearEN.Text = "School Year:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSubject);
            this.groupBox2.Controls.Add(this.cmbClassName);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.txtTeacher);
            this.groupBox2.Controls.Add(this.lblSubEN);
            this.groupBox2.Controls.Add(this.cmbSchoolYear);
            this.groupBox2.Controls.Add(this.lblClassNameEN);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTechEN);
            this.groupBox2.Controls.Add(this.btnTech);
            this.groupBox2.Controls.Add(this.lblSchoolYearEN);
            this.groupBox2.Location = new System.Drawing.Point(7, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 69);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID:";
            // 
            // lblTechEN
            // 
            this.lblTechEN.AutoSize = true;
            this.lblTechEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechEN.Location = new System.Drawing.Point(150, 18);
            this.lblTechEN.Name = "lblTechEN";
            this.lblTechEN.Size = new System.Drawing.Size(63, 15);
            this.lblTechEN.TabIndex = 20;
            this.lblTechEN.Text = "Teacher:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(740, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(12, 133);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(183, 21);
            this.lblSearch.TabIndex = 122;
            this.lblSearch.Text = "Search by UserName";
            // 
            // Encoding_Of_Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(828, 504);
            this.ControlBox = false;
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvwStudList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchEN);
            this.Controls.Add(this.groupBox2);
            this.Name = "Encoding_Of_Grades";
            this.Load += new System.EventHandler(this.Encoding_Of_Grades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader txt2ndGrading;
        private System.Windows.Forms.ColumnHeader txt1stgrading;
        private System.Windows.Forms.ColumnHeader txtStudName;
        private System.Windows.Forms.ColumnHeader txtstudID;
        private System.Windows.Forms.ListView lvwStudList;
        private System.Windows.Forms.ColumnHeader txt3rdGrading;
        private System.Windows.Forms.ColumnHeader txt4rthGrading;
        private System.Windows.Forms.ColumnHeader txtAverage;
        private System.Windows.Forms.ColumnHeader txtRemarks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchEN;
        internal System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblSubEN;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.Label lblClassNameEN;
        internal System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnTech;
        private System.Windows.Forms.Label lblSchoolYearEN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTechEN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSearch;
    }
}