
namespace GOC_GS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFacultyId = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlAdminView = new System.Windows.Forms.Panel();
            this.btnStudentSubject = new System.Windows.Forms.Button();
            this.btnConSettings = new System.Windows.Forms.Button();
            this.btnStudentData = new System.Windows.Forms.Button();
            this.btnFileMaintenance = new System.Windows.Forms.Button();
            this.btnFacultyLoading = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.pnlTeacherView = new System.Windows.Forms.Panel();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnGrading = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAllContainer = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlAdminView.SuspendLayout();
            this.pnlTeacherView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.lblUserStatus);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.lblUser);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1150, 59);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1044;
            this.label2.Text = "User Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1043;
            this.label1.Text = "Active User:";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.White;
            this.lblUserStatus.Location = new System.Drawing.Point(120, 32);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(90, 18);
            this.lblUserStatus.TabIndex = 1042;
            this.lblUserStatus.Text = "Adminstrator";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1033, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 35);
            this.btnLogout.TabIndex = 68;
            this.btnLogout.Text = "     Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(118, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 18);
            this.lblUser.TabIndex = 69;
            this.lblUser.Text = "Efraim Basilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 1045;
            this.label3.Text = "ID No.";
            // 
            // lblFacultyId
            // 
            this.lblFacultyId.AutoSize = true;
            this.lblFacultyId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyId.ForeColor = System.Drawing.Color.White;
            this.lblFacultyId.Location = new System.Drawing.Point(93, 179);
            this.lblFacultyId.Name = "lblFacultyId";
            this.lblFacultyId.Size = new System.Drawing.Size(69, 18);
            this.lblFacultyId.TabIndex = 1041;
            this.lblFacultyId.Text = "2021-0001";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pnlLeft.Controls.Add(this.pnlAdminView);
            this.pnlLeft.Controls.Add(this.pnlTeacherView);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.lblFacultyId);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 729);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlAdminView
            // 
            this.pnlAdminView.Controls.Add(this.btnStudentSubject);
            this.pnlAdminView.Controls.Add(this.btnConSettings);
            this.pnlAdminView.Controls.Add(this.btnStudentData);
            this.pnlAdminView.Controls.Add(this.btnFileMaintenance);
            this.pnlAdminView.Controls.Add(this.btnFacultyLoading);
            this.pnlAdminView.Controls.Add(this.btnDashBoard);
            this.pnlAdminView.Location = new System.Drawing.Point(6, 200);
            this.pnlAdminView.Name = "pnlAdminView";
            this.pnlAdminView.Size = new System.Drawing.Size(187, 517);
            this.pnlAdminView.TabIndex = 0;
            this.pnlAdminView.Visible = false;
            // 
            // btnStudentSubject
            // 
            this.btnStudentSubject.FlatAppearance.BorderSize = 0;
            this.btnStudentSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnStudentSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentSubject.Image")));
            this.btnStudentSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentSubject.Location = new System.Drawing.Point(8, 164);
            this.btnStudentSubject.Name = "btnStudentSubject";
            this.btnStudentSubject.Size = new System.Drawing.Size(170, 46);
            this.btnStudentSubject.TabIndex = 1045;
            this.btnStudentSubject.Text = "    Student Subject";
            this.btnStudentSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentSubject.UseVisualStyleBackColor = true;
            this.btnStudentSubject.Click += new System.EventHandler(this.btnStudentSubject_Click_1);
            // 
            // btnConSettings
            // 
            this.btnConSettings.FlatAppearance.BorderSize = 0;
            this.btnConSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnConSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnConSettings.Image")));
            this.btnConSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConSettings.Location = new System.Drawing.Point(3, 455);
            this.btnConSettings.Name = "btnConSettings";
            this.btnConSettings.Size = new System.Drawing.Size(181, 46);
            this.btnConSettings.TabIndex = 69;
            this.btnConSettings.Text = "     Connection Settings";
            this.btnConSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConSettings.UseVisualStyleBackColor = true;
            this.btnConSettings.Click += new System.EventHandler(this.btnConSettings_Click);
            // 
            // btnStudentData
            // 
            this.btnStudentData.FlatAppearance.BorderSize = 0;
            this.btnStudentData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnStudentData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentData.Location = new System.Drawing.Point(13, 216);
            this.btnStudentData.Name = "btnStudentData";
            this.btnStudentData.Size = new System.Drawing.Size(158, 46);
            this.btnStudentData.TabIndex = 1044;
            this.btnStudentData.Text = "Student Profile";
            this.btnStudentData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentData.UseVisualStyleBackColor = true;
            this.btnStudentData.Click += new System.EventHandler(this.btnStudentData_Click_1);
            // 
            // btnFileMaintenance
            // 
            this.btnFileMaintenance.FlatAppearance.BorderSize = 0;
            this.btnFileMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileMaintenance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnFileMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btnFileMaintenance.Image")));
            this.btnFileMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileMaintenance.Location = new System.Drawing.Point(8, 60);
            this.btnFileMaintenance.Name = "btnFileMaintenance";
            this.btnFileMaintenance.Size = new System.Drawing.Size(170, 46);
            this.btnFileMaintenance.TabIndex = 1043;
            this.btnFileMaintenance.Text = "    File Maintenance";
            this.btnFileMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileMaintenance.UseVisualStyleBackColor = true;
            this.btnFileMaintenance.Click += new System.EventHandler(this.btnFileMaintenance_Click);
            // 
            // btnFacultyLoading
            // 
            this.btnFacultyLoading.FlatAppearance.BorderSize = 0;
            this.btnFacultyLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacultyLoading.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacultyLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnFacultyLoading.Image = ((System.Drawing.Image)(resources.GetObject("btnFacultyLoading.Image")));
            this.btnFacultyLoading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacultyLoading.Location = new System.Drawing.Point(8, 112);
            this.btnFacultyLoading.Name = "btnFacultyLoading";
            this.btnFacultyLoading.Size = new System.Drawing.Size(170, 46);
            this.btnFacultyLoading.TabIndex = 1042;
            this.btnFacultyLoading.Text = "    Faculty Loads";
            this.btnFacultyLoading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacultyLoading.UseVisualStyleBackColor = true;
            this.btnFacultyLoading.Click += new System.EventHandler(this.btnFacultyLoading_Click_1);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(8, 8);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(170, 46);
            this.btnDashBoard.TabIndex = 1041;
            this.btnDashBoard.Text = "     Dashboard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click_1);
            // 
            // pnlTeacherView
            // 
            this.pnlTeacherView.Controls.Add(this.btnViewGrades);
            this.pnlTeacherView.Controls.Add(this.btnGrading);
            this.pnlTeacherView.Location = new System.Drawing.Point(4, 206);
            this.pnlTeacherView.Name = "pnlTeacherView";
            this.pnlTeacherView.Size = new System.Drawing.Size(189, 112);
            this.pnlTeacherView.TabIndex = 0;
            this.pnlTeacherView.Visible = false;
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.FlatAppearance.BorderSize = 0;
            this.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrades.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnViewGrades.Image = ((System.Drawing.Image)(resources.GetObject("btnViewGrades.Image")));
            this.btnViewGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGrades.Location = new System.Drawing.Point(11, 60);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(170, 46);
            this.btnViewGrades.TabIndex = 76;
            this.btnViewGrades.Text = "     View Grades";
            this.btnViewGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Visible = false;
            // 
            // btnGrading
            // 
            this.btnGrading.FlatAppearance.BorderSize = 0;
            this.btnGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrading.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnGrading.Image = ((System.Drawing.Image)(resources.GetObject("btnGrading.Image")));
            this.btnGrading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.Location = new System.Drawing.Point(13, 8);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Size = new System.Drawing.Size(170, 46);
            this.btnGrading.TabIndex = 75;
            this.btnGrading.Text = "     Grading";
            this.btnGrading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrading.UseVisualStyleBackColor = true;
            this.btnGrading.Click += new System.EventHandler(this.btnGrading_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1037;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // pnlAllContainer
            // 
            this.pnlAllContainer.BackgroundImage = global::GOC_GS.Properties.Resources.goc_logo;
            this.pnlAllContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllContainer.Location = new System.Drawing.Point(200, 59);
            this.pnlAllContainer.Name = "pnlAllContainer";
            this.pnlAllContainer.Size = new System.Drawing.Size(1150, 670);
            this.pnlAllContainer.TabIndex = 26;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlAllContainer);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlAdminView.ResumeLayout(false);
            this.pnlTeacherView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.Button btnConSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlAllContainer;
        public System.Windows.Forms.Label lblUserStatus;
        public System.Windows.Forms.Label lblFacultyId;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAdminView;
        public System.Windows.Forms.Button btnStudentSubject;
        public System.Windows.Forms.Button btnStudentData;
        public System.Windows.Forms.Button btnFileMaintenance;
        public System.Windows.Forms.Button btnFacultyLoading;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel pnlTeacherView;
        public System.Windows.Forms.Button btnViewGrades;
        public System.Windows.Forms.Button btnGrading;
    }
}

