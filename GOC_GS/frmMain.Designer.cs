
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGrading = new System.Windows.Forms.Button();
            this.btnFacultyLoading = new System.Windows.Forms.Button();
            this.btnConSettings = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAllContainer = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1150, 51);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
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
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pnlLeft.Controls.Add(this.btnViewGrades);
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.btnGrading);
            this.pnlLeft.Controls.Add(this.btnFacultyLoading);
            this.pnlLeft.Controls.Add(this.btnConSettings);
            this.pnlLeft.Controls.Add(this.btnDashBoard);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 729);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.FlatAppearance.BorderSize = 0;
            this.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrades.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnViewGrades.Image = ((System.Drawing.Image)(resources.GetObject("btnViewGrades.Image")));
            this.btnViewGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGrades.Location = new System.Drawing.Point(17, 318);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(170, 46);
            this.btnViewGrades.TabIndex = 74;
            this.btnViewGrades.Text = "     View Grades";
            this.btnViewGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 46);
            this.button1.TabIndex = 73;
            this.button1.Text = "    File Maintenance";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGrading
            // 
            this.btnGrading.FlatAppearance.BorderSize = 0;
            this.btnGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrading.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnGrading.Image = ((System.Drawing.Image)(resources.GetObject("btnGrading.Image")));
            this.btnGrading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.Location = new System.Drawing.Point(17, 266);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Size = new System.Drawing.Size(170, 46);
            this.btnGrading.TabIndex = 72;
            this.btnGrading.Text = "     Grading";
            this.btnGrading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrading.UseVisualStyleBackColor = true;
            this.btnGrading.Click += new System.EventHandler(this.btnGrading_Click);
            // 
            // btnFacultyLoading
            // 
            this.btnFacultyLoading.FlatAppearance.BorderSize = 0;
            this.btnFacultyLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacultyLoading.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacultyLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnFacultyLoading.Image = ((System.Drawing.Image)(resources.GetObject("btnFacultyLoading.Image")));
            this.btnFacultyLoading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacultyLoading.Location = new System.Drawing.Point(11, 371);
            this.btnFacultyLoading.Name = "btnFacultyLoading";
            this.btnFacultyLoading.Size = new System.Drawing.Size(170, 46);
            this.btnFacultyLoading.TabIndex = 70;
            this.btnFacultyLoading.Text = "    Faculty Loads";
            this.btnFacultyLoading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacultyLoading.UseVisualStyleBackColor = true;
            this.btnFacultyLoading.Click += new System.EventHandler(this.btnFacultyLoading_Click);
            // 
            // btnConSettings
            // 
            this.btnConSettings.FlatAppearance.BorderSize = 0;
            this.btnConSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConSettings.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnConSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnConSettings.Image")));
            this.btnConSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConSettings.Location = new System.Drawing.Point(12, 671);
            this.btnConSettings.Name = "btnConSettings";
            this.btnConSettings.Size = new System.Drawing.Size(170, 46);
            this.btnConSettings.TabIndex = 69;
            this.btnConSettings.Text = "     Connection Settings";
            this.btnConSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConSettings.UseVisualStyleBackColor = true;
            this.btnConSettings.Click += new System.EventHandler(this.btnConSettings_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(17, 214);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(170, 46);
            this.btnDashBoard.TabIndex = 68;
            this.btnDashBoard.Text = "     Dashboard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
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
            this.pnlAllContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllContainer.Location = new System.Drawing.Point(200, 51);
            this.pnlAllContainer.Name = "pnlAllContainer";
            this.pnlAllContainer.Size = new System.Drawing.Size(1150, 678);
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
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.Button btnViewGrades;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnGrading;
        public System.Windows.Forms.Button btnFacultyLoading;
        public System.Windows.Forms.Button btnConSettings;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlAllContainer;
    }
}

