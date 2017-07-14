namespace Enrollment_System
{
    partial class Section
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cmbYearLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSecName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSecID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtStudAllowed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMaxAverage = new System.Windows.Forms.TextBox();
            this.txtMinAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblSecName = new System.Windows.Forms.Label();
            this.lblRecID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchLast = new System.Windows.Forms.TextBox();
            this.lvwListSection = new System.Windows.Forms.ListView();
            this.lvwID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSecname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwYRlevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwlClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwMinAve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwmaxAve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwNumStud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Section";
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtClassName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(107, 121);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(207, 27);
            this.txtClassName.TabIndex = 24;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearLevel.FormattingEnabled = true;
            this.cmbYearLevel.Location = new System.Drawing.Point(107, 88);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(110, 29);
            this.cmbYearLevel.TabIndex = 25;
            this.cmbYearLevel.SelectedIndexChanged += new System.EventHandler(this.cmbYearLevel_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "%";
            // 
            // txtSecName
            // 
            this.txtSecName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSecName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecName.Location = new System.Drawing.Point(107, 57);
            this.txtSecName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.Size = new System.Drawing.Size(207, 27);
            this.txtSecName.TabIndex = 23;
            this.txtSecName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecName.TextChanged += new System.EventHandler(this.txtSecName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            // 
            // txtSecID
            // 
            this.txtSecID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSecID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecID.Location = new System.Drawing.Point(107, 26);
            this.txtSecID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecID.Name = "txtSecID";
            this.txtSecID.ReadOnly = true;
            this.txtSecID.Size = new System.Drawing.Size(140, 27);
            this.txtSecID.TabIndex = 22;
            this.txtSecID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of Students Allowed";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(-3, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 57);
            this.panel1.TabIndex = 29;
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
            // txtStudAllowed
            // 
            this.txtStudAllowed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudAllowed.Location = new System.Drawing.Point(210, 217);
            this.txtStudAllowed.Multiline = true;
            this.txtStudAllowed.Name = "txtStudAllowed";
            this.txtStudAllowed.Size = new System.Drawing.Size(63, 29);
            this.txtStudAllowed.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maximum Average:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minimum Average:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtClassName);
            this.groupBox2.Controls.Add(this.cmbYearLevel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSecName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSecID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtStudAllowed);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaxAverage);
            this.groupBox2.Controls.Add(this.txtMinAverage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblYearLevel);
            this.groupBox2.Controls.Add(this.lblSecName);
            this.groupBox2.Controls.Add(this.lblRecID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 318);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(176, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 34);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(92, 271);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 34);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(260, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(8, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMaxAverage
            // 
            this.txtMaxAverage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAverage.Location = new System.Drawing.Point(145, 184);
            this.txtMaxAverage.Multiline = true;
            this.txtMaxAverage.Name = "txtMaxAverage";
            this.txtMaxAverage.Size = new System.Drawing.Size(53, 26);
            this.txtMaxAverage.TabIndex = 9;
            // 
            // txtMinAverage
            // 
            this.txtMinAverage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinAverage.Location = new System.Drawing.Point(145, 153);
            this.txtMinAverage.Multiline = true;
            this.txtMinAverage.Name = "txtMinAverage";
            this.txtMinAverage.Size = new System.Drawing.Size(53, 27);
            this.txtMinAverage.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Class Name";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.Location = new System.Drawing.Point(12, 95);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(74, 15);
            this.lblYearLevel.TabIndex = 5;
            this.lblYearLevel.Text = "Year Level";
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecName.Location = new System.Drawing.Point(12, 64);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(97, 15);
            this.lblSecName.TabIndex = 3;
            this.lblSecName.Text = "Section Name";
            // 
            // lblRecID
            // 
            this.lblRecID.AutoSize = true;
            this.lblRecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecID.Location = new System.Drawing.Point(12, 33);
            this.lblRecID.Name = "lblRecID";
            this.lblRecID.Size = new System.Drawing.Size(77, 15);
            this.lblRecID.TabIndex = 0;
            this.lblRecID.Text = "Section ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchLast);
            this.groupBox1.Controls.Add(this.lvwListSection);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Location = new System.Drawing.Point(365, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 318);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // txtSearchLast
            // 
            this.txtSearchLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLast.Location = new System.Drawing.Point(76, 12);
            this.txtSearchLast.Multiline = true;
            this.txtSearchLast.Name = "txtSearchLast";
            this.txtSearchLast.Size = new System.Drawing.Size(324, 26);
            this.txtSearchLast.TabIndex = 161;
            this.txtSearchLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchLast.TextChanged += new System.EventHandler(this.txtSearchLast_TextChanged);
            // 
            // lvwListSection
            // 
            this.lvwListSection.BackColor = System.Drawing.Color.White;
            this.lvwListSection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwID,
            this.lvwSecname,
            this.lvwYRlevel,
            this.lvwlClassName,
            this.lvwMinAve,
            this.lvwmaxAve,
            this.lvwNumStud,
            this.lvwDateCreated});
            this.lvwListSection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListSection.FullRowSelect = true;
            this.lvwListSection.GridLines = true;
            this.lvwListSection.Location = new System.Drawing.Point(6, 44);
            this.lvwListSection.Name = "lvwListSection";
            this.lvwListSection.Size = new System.Drawing.Size(558, 268);
            this.lvwListSection.TabIndex = 160;
            this.lvwListSection.UseCompatibleStateImageBehavior = false;
            this.lvwListSection.View = System.Windows.Forms.View.Details;
            this.lvwListSection.SelectedIndexChanged += new System.EventHandler(this.lvwListSection_SelectedIndexChanged);
            // 
            // lvwID
            // 
            this.lvwID.Text = "SectionID";
            this.lvwID.Width = 0;
            // 
            // lvwSecname
            // 
            this.lvwSecname.Text = "Section Name";
            this.lvwSecname.Width = 180;
            // 
            // lvwYRlevel
            // 
            this.lvwYRlevel.Text = "Year Level";
            this.lvwYRlevel.Width = 180;
            // 
            // lvwlClassName
            // 
            this.lvwlClassName.Text = "Class Name";
            this.lvwlClassName.Width = 200;
            // 
            // lvwMinAve
            // 
            this.lvwMinAve.Text = "MinAverage";
            this.lvwMinAve.Width = 110;
            // 
            // lvwmaxAve
            // 
            this.lvwmaxAve.Text = "MaxAverage";
            this.lvwmaxAve.Width = 110;
            // 
            // lvwNumStud
            // 
            this.lvwNumStud.Text = "Number Students";
            this.lvwNumStud.Width = 150;
            // 
            // lvwDateCreated
            // 
            this.lvwDateCreated.Text = "Date Created";
            this.lvwDateCreated.Width = 150;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(6, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(66, 18);
            this.lblSearch.TabIndex = 29;
            this.lblSearch.Text = "Search:";
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(947, 386);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Section";
            this.Load += new System.EventHandler(this.Section_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ComboBox cmbYearLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSecName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSecID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtStudAllowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaxAverage;
        private System.Windows.Forms.TextBox txtMinAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.Label lblRecID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchLast;
        internal System.Windows.Forms.ListView lvwListSection;
        private System.Windows.Forms.ColumnHeader lvwID;
        private System.Windows.Forms.ColumnHeader lvwSecname;
        private System.Windows.Forms.ColumnHeader lvwYRlevel;
        private System.Windows.Forms.ColumnHeader lvwlClassName;
        private System.Windows.Forms.ColumnHeader lvwMinAve;
        private System.Windows.Forms.ColumnHeader lvwmaxAve;
        private System.Windows.Forms.ColumnHeader lvwNumStud;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ColumnHeader lvwDateCreated;
    }
}