
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.dgvFacultyList.Location = new System.Drawing.Point(13, 190);
            this.dgvFacultyList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvFacultyList.Name = "dgvFacultyList";
            this.dgvFacultyList.ReadOnly = true;
            this.dgvFacultyList.RowHeadersVisible = false;
            this.dgvFacultyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyList.Size = new System.Drawing.Size(1123, 463);
            this.dgvFacultyList.TabIndex = 7936;
            this.dgvFacultyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultyList_CellContentClick);
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblLname.Location = new System.Drawing.Point(44, 131);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(72, 20);
            this.lblLname.TabIndex = 7937;
            this.lblLname.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7938;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7939;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label4.Location = new System.Drawing.Point(503, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7940;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label5.Location = new System.Drawing.Point(442, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 7941;
            this.label5.Text = "Specialize Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label6.Location = new System.Drawing.Point(483, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 7942;
            this.label6.Text = "Adviser Of:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label7.Location = new System.Drawing.Point(436, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 7943;
            this.label7.Text = "Employment Status:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(120, 127);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(233, 25);
            this.txtLName.TabIndex = 7944;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(120, 61);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(233, 25);
            this.txtFName.TabIndex = 7945;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(120, 94);
            this.txtMName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(233, 25);
            this.txtMName.TabIndex = 7946;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(561, 28);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(233, 28);
            this.cmbCourse.TabIndex = 7947;
            // 
            // cmbSpecializeSubject
            // 
            this.cmbSpecializeSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecializeSubject.FormattingEnabled = true;
            this.cmbSpecializeSubject.Location = new System.Drawing.Point(561, 65);
            this.cmbSpecializeSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSpecializeSubject.Name = "cmbSpecializeSubject";
            this.cmbSpecializeSubject.Size = new System.Drawing.Size(233, 28);
            this.cmbSpecializeSubject.TabIndex = 7948;
            // 
            // cmbAdviserOf
            // 
            this.cmbAdviserOf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdviserOf.FormattingEnabled = true;
            this.cmbAdviserOf.Location = new System.Drawing.Point(561, 106);
            this.cmbAdviserOf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAdviserOf.Name = "cmbAdviserOf";
            this.cmbAdviserOf.Size = new System.Drawing.Size(233, 28);
            this.cmbAdviserOf.TabIndex = 7949;
            // 
            // cmbEmpStatus
            // 
            this.cmbEmpStatus.FormattingEnabled = true;
            this.cmbEmpStatus.Location = new System.Drawing.Point(561, 144);
            this.cmbEmpStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmpStatus.Name = "cmbEmpStatus";
            this.cmbEmpStatus.Size = new System.Drawing.Size(233, 28);
            this.cmbEmpStatus.TabIndex = 7950;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.btnAdd.Image = global::GOC_GS.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(960, 137);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 44);
            this.btnAdd.TabIndex = 7951;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1051, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 7952;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.Location = new System.Drawing.Point(120, 28);
            this.txtFacultyId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.Size = new System.Drawing.Size(233, 25);
            this.txtFacultyId.TabIndex = 7954;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7953;
            this.label1.Text = "Faculty Id:";
            // 
            // pbClose
            // 
            this.pbClose.Image = global::GOC_GS.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(1116, 14);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 7982;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.txtFacultyId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbEmpStatus);
            this.Controls.Add(this.cmbAdviserOf);
            this.Controls.Add(this.cmbSpecializeSubject);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.dgvFacultyList);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private System.Windows.Forms.Label label6;
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
    }
}