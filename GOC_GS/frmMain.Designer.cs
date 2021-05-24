
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGrading = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.pnlTop.Controls.Add(this.button2);
            this.pnlTop.Controls.Add(this.pnlMain);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1150, 57);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(87)))));
            this.pnlLeft.Controls.Add(this.btnViewGrades);
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.btnGrading);
            this.pnlLeft.Controls.Add(this.btnTeacher);
            this.pnlLeft.Controls.Add(this.button3);
            this.pnlLeft.Controls.Add(this.button10);
            this.pnlLeft.Controls.Add(this.btnDashBoard);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 729);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1144, 654);
            this.pnlMain.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1033, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 68;
            this.button2.Text = "     Log out";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.FlatAppearance.BorderSize = 0;
            this.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnViewGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnViewGrades.Image = ((System.Drawing.Image)(resources.GetObject("btnViewGrades.Image")));
            this.btnViewGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGrades.Location = new System.Drawing.Point(17, 267);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(170, 46);
            this.btnViewGrades.TabIndex = 74;
            this.btnViewGrades.Text = "     View Grades";
            this.btnViewGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewGrades.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 46);
            this.button1.TabIndex = 73;
            this.button1.Text = "     Teacher Maintenance";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGrading
            // 
            this.btnGrading.FlatAppearance.BorderSize = 0;
            this.btnGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrading.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnGrading.Image = ((System.Drawing.Image)(resources.GetObject("btnGrading.Image")));
            this.btnGrading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrading.Location = new System.Drawing.Point(17, 215);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Size = new System.Drawing.Size(170, 46);
            this.btnGrading.TabIndex = 72;
            this.btnGrading.Text = "     Grading";
            this.btnGrading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrading.UseVisualStyleBackColor = true;
            // 
            // btnTeacher
            // 
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(14, 423);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(170, 46);
            this.btnTeacher.TabIndex = 71;
            this.btnTeacher.Text = "     Teacher Profile";
            this.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(11, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 46);
            this.button3.TabIndex = 70;
            this.button3.Text = "    Grading Set-Ups";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(17, 671);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(170, 46);
            this.button10.TabIndex = 69;
            this.button10.Text = "     Settings";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(14, 319);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(170, 46);
            this.btnDashBoard.TabIndex = 68;
            this.btnDashBoard.Text = "     Dashboard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlLeft;
        public System.Windows.Forms.Button btnViewGrades;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnGrading;
        public System.Windows.Forms.Button btnTeacher;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel pnlMain;
    }
}

