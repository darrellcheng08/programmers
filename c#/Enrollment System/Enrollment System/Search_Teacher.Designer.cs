namespace Enrollment_System
{
    partial class Search_Teacher
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
            this.lvwListStudEnroll = new System.Windows.Forms.ListView();
            this.vlwTeacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchLast = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListStudEnroll
            // 
            this.lvwListStudEnroll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vlwTeacherID,
            this.lvwFirstName,
            this.lvwMiddleName,
            this.lvwLastName,
            this.lvwPosition,
            this.lvwAddress,
            this.lvwContact,
            this.lvwDateCreated});
            this.lvwListStudEnroll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListStudEnroll.FullRowSelect = true;
            this.lvwListStudEnroll.GridLines = true;
            this.lvwListStudEnroll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwListStudEnroll.Location = new System.Drawing.Point(4, 69);
            this.lvwListStudEnroll.Name = "lvwListStudEnroll";
            this.lvwListStudEnroll.Size = new System.Drawing.Size(593, 230);
            this.lvwListStudEnroll.TabIndex = 159;
            this.lvwListStudEnroll.UseCompatibleStateImageBehavior = false;
            this.lvwListStudEnroll.View = System.Windows.Forms.View.Details;
            this.lvwListStudEnroll.DoubleClick += new System.EventHandler(this.lvwListStudEnroll_DoubleClick);
            // 
            // vlwTeacherID
            // 
            this.vlwTeacherID.Text = "TeacherID";
            this.vlwTeacherID.Width = 180;
            // 
            // lvwFirstName
            // 
            this.lvwFirstName.Text = "First Name";
            this.lvwFirstName.Width = 210;
            // 
            // lvwMiddleName
            // 
            this.lvwMiddleName.Text = "Middle Name";
            this.lvwMiddleName.Width = 200;
            // 
            // lvwLastName
            // 
            this.lvwLastName.Text = "Last Name";
            this.lvwLastName.Width = 200;
            // 
            // lvwPosition
            // 
            this.lvwPosition.Text = "Position";
            this.lvwPosition.Width = 150;
            // 
            // lvwAddress
            // 
            this.lvwAddress.Text = "Address";
            this.lvwAddress.Width = 250;
            // 
            // lvwContact
            // 
            this.lvwContact.Text = "Contact";
            this.lvwContact.Width = 150;
            // 
            // lvwDateCreated
            // 
            this.lvwDateCreated.Text = "Date Created";
            this.lvwDateCreated.Width = 150;
            // 
            // txtSearchLast
            // 
            this.txtSearchLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLast.Location = new System.Drawing.Point(199, 13);
            this.txtSearchLast.Multiline = true;
            this.txtSearchLast.Name = "txtSearchLast";
            this.txtSearchLast.Size = new System.Drawing.Size(287, 31);
            this.txtSearchLast.TabIndex = 46;
            this.txtSearchLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchLast.TextChanged += new System.EventHandler(this.txtSearchLast_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(517, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelect.Location = new System.Drawing.Point(431, 304);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 34);
            this.btnSelect.TabIndex = 157;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearchLast);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Location = new System.Drawing.Point(4, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 56);
            this.panel2.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 124;
            this.label2.Text = "Search by LastName";
            // 
            // Search_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(601, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvwListStudEnroll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Search_Teacher";
            this.Load += new System.EventHandler(this.Search_Teacher_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lvwListStudEnroll;
        private System.Windows.Forms.ColumnHeader vlwTeacherID;
        private System.Windows.Forms.ColumnHeader lvwFirstName;
        private System.Windows.Forms.ColumnHeader lvwMiddleName;
        private System.Windows.Forms.ColumnHeader lvwLastName;
        private System.Windows.Forms.ColumnHeader lvwPosition;
        private System.Windows.Forms.ColumnHeader lvwAddress;
        private System.Windows.Forms.ColumnHeader lvwContact;
        private System.Windows.Forms.ColumnHeader lvwDateCreated;
        private System.Windows.Forms.TextBox txtSearchLast;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}