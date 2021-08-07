
namespace GOC_GS
{
    partial class frmFaculty
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
            this.dgvFacultyList = new System.Windows.Forms.DataGridView();
            this.lblLname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdviserOf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbSpecializeSubject = new System.Windows.Forms.ComboBox();
            this.cmbAdviserOf = new System.Windows.Forms.ComboBox();
            this.cmbEmpStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFacultyId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.cmbEStatus = new System.Windows.Forms.ComboBox();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.txtSpecialSubj = new System.Windows.Forms.TextBox();
            this.chkNotAdviser = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacultyList
            // 
            this.dgvFacultyList.AllowUserToAddRows = false;
            this.dgvFacultyList.AllowUserToDeleteRows = false;
            this.dgvFacultyList.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacultyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultyList.Location = new System.Drawing.Point(23, 178);
            this.dgvFacultyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFacultyList.Name = "dgvFacultyList";
            this.dgvFacultyList.ReadOnly = true;
            this.dgvFacultyList.RowHeadersVisible = false;
            this.dgvFacultyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyList.Size = new System.Drawing.Size(1104, 393);
            this.dgvFacultyList.TabIndex = 7936;
            this.dgvFacultyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultyList_CellContentClick);
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(54, 130);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(82, 19);
            this.lblLname.TabIndex = 7937;
            this.lblLname.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 7938;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 7939;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 7940;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 7941;
            this.label5.Text = "Specialize Subject:";
            // 
            // lblAdviserOf
            // 
            this.lblAdviserOf.AutoSize = true;
            this.lblAdviserOf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdviserOf.Location = new System.Drawing.Point(429, 135);
            this.lblAdviserOf.Name = "lblAdviserOf";
            this.lblAdviserOf.Size = new System.Drawing.Size(81, 19);
            this.lblAdviserOf.TabIndex = 7942;
            this.lblAdviserOf.Text = "Adviser Of:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 7943;
            this.label7.Text = "Employment Status:";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(143, 127);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 27);
            this.txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(143, 61);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 27);
            this.txtFName.TabIndex = 2;
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(143, 94);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(200, 27);
            this.txtMName.TabIndex = 3;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(793, 223);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(200, 21);
            this.cmbCourse.TabIndex = 7947;
            // 
            // cmbSpecializeSubject
            // 
            this.cmbSpecializeSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecializeSubject.FormattingEnabled = true;
            this.cmbSpecializeSubject.Location = new System.Drawing.Point(875, 212);
            this.cmbSpecializeSubject.Name = "cmbSpecializeSubject";
            this.cmbSpecializeSubject.Size = new System.Drawing.Size(200, 21);
            this.cmbSpecializeSubject.TabIndex = 7948;
            // 
            // cmbAdviserOf
            // 
            this.cmbAdviserOf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdviserOf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdviserOf.FormattingEnabled = true;
            this.cmbAdviserOf.Items.AddRange(new object[] {
            "Subject Teacher"});
            this.cmbAdviserOf.Location = new System.Drawing.Point(532, 125);
            this.cmbAdviserOf.Name = "cmbAdviserOf";
            this.cmbAdviserOf.Size = new System.Drawing.Size(97, 27);
            this.cmbAdviserOf.TabIndex = 7;
            // 
            // cmbEmpStatus
            // 
            this.cmbEmpStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpStatus.FormattingEnabled = true;
            this.cmbEmpStatus.Items.AddRange(new object[] {
            "Fulltime",
            "Partime",
            "Out"});
            this.cmbEmpStatus.Location = new System.Drawing.Point(901, 212);
            this.cmbEmpStatus.Name = "cmbEmpStatus";
            this.cmbEmpStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbEmpStatus.TabIndex = 7950;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::GOC_GS.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(963, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "   &Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1054, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyId.Location = new System.Drawing.Point(143, 29);
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.ReadOnly = true;
            this.txtFacultyId.Size = new System.Drawing.Size(99, 27);
            this.txtFacultyId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 7953;
            this.label1.Text = "Faculty Id:";
            // 
            // pbClose
            // 
            this.pbClose.Image = global::GOC_GS.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(1122, 12);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(17, 19);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 7982;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(532, 28);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(200, 27);
            this.txtCourse.TabIndex = 5;
            // 
            // cmbEStatus
            // 
            this.cmbEStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEStatus.FormattingEnabled = true;
            this.cmbEStatus.Items.AddRange(new object[] {
            "Full-time",
            "Part-time"});
            this.cmbEStatus.Location = new System.Drawing.Point(532, 94);
            this.cmbEStatus.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmbEStatus.Name = "cmbEStatus";
            this.cmbEStatus.Size = new System.Drawing.Size(200, 27);
            this.cmbEStatus.TabIndex = 8;
            // 
            // cmbEmp
            // 
            this.cmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(891, 212);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(200, 21);
            this.cmbEmp.TabIndex = 7985;
            // 
            // txtSpecialSubj
            // 
            this.txtSpecialSubj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialSubj.Location = new System.Drawing.Point(532, 61);
            this.txtSpecialSubj.Name = "txtSpecialSubj";
            this.txtSpecialSubj.Size = new System.Drawing.Size(200, 27);
            this.txtSpecialSubj.TabIndex = 6;
            // 
            // chkNotAdviser
            // 
            this.chkNotAdviser.AutoSize = true;
            this.chkNotAdviser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotAdviser.Location = new System.Drawing.Point(635, 131);
            this.chkNotAdviser.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.chkNotAdviser.Name = "chkNotAdviser";
            this.chkNotAdviser.Size = new System.Drawing.Size(103, 23);
            this.chkNotAdviser.TabIndex = 7987;
            this.chkNotAdviser.Text = "Not Adviser";
            this.chkNotAdviser.UseVisualStyleBackColor = true;
            this.chkNotAdviser.CheckedChanged += new System.EventHandler(this.chkNotAdviser_CheckedChanged);
            this.chkNotAdviser.Click += new System.EventHandler(this.chkNotAdviser_Click);
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.chkNotAdviser);
            this.Controls.Add(this.txtSpecialSubj);
            this.Controls.Add(this.cmbEStatus);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.txtFacultyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbAdviserOf);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAdviserOf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.dgvFacultyList);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbEmpStatus);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.cmbSpecializeSubject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFaculty";
            this.Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacultyList;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdviserOf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbSpecializeSubject;
        private System.Windows.Forms.ComboBox cmbAdviserOf;
        private System.Windows.Forms.ComboBox cmbEmpStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFacultyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.ComboBox cmbEStatus;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.TextBox txtSpecialSubj;
        private System.Windows.Forms.CheckBox chkNotAdviser;
    }
}