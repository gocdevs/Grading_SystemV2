
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacultyList
            // 
            this.dgvFacultyList.AllowUserToAddRows = false;
            this.dgvFacultyList.AllowUserToDeleteRows = false;
            this.dgvFacultyList.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacultyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultyList.Location = new System.Drawing.Point(5, 212);
            this.dgvFacultyList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacultyList.Name = "dgvFacultyList";
            this.dgvFacultyList.ReadOnly = true;
            this.dgvFacultyList.RowHeadersVisible = false;
            this.dgvFacultyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyList.Size = new System.Drawing.Size(1123, 523);
            this.dgvFacultyList.TabIndex = 7936;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(12, 24);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(59, 16);
            this.lblLname.TabIndex = 7937;
            this.lblLname.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 7938;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 7939;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7940;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7941;
            this.label5.Text = "Specialize Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 7942;
            this.label6.Text = "Adviser Of:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 7943;
            this.label7.Text = "Employment Status:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(77, 21);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 21);
            this.txtLName.TabIndex = 7944;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(77, 54);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 21);
            this.txtFName.TabIndex = 7945;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(77, 83);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(200, 21);
            this.txtMName.TabIndex = 7946;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(77, 115);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(200, 24);
            this.cmbCourse.TabIndex = 7947;
            // 
            // cmbSpecializeSubject
            // 
            this.cmbSpecializeSubject.FormattingEnabled = true;
            this.cmbSpecializeSubject.Location = new System.Drawing.Point(438, 21);
            this.cmbSpecializeSubject.Name = "cmbSpecializeSubject";
            this.cmbSpecializeSubject.Size = new System.Drawing.Size(228, 24);
            this.cmbSpecializeSubject.TabIndex = 7948;
            // 
            // cmbAdviserOf
            // 
            this.cmbAdviserOf.FormattingEnabled = true;
            this.cmbAdviserOf.Location = new System.Drawing.Point(438, 54);
            this.cmbAdviserOf.Name = "cmbAdviserOf";
            this.cmbAdviserOf.Size = new System.Drawing.Size(228, 24);
            this.cmbAdviserOf.TabIndex = 7949;
            // 
            // cmbEmpStatus
            // 
            this.cmbEmpStatus.FormattingEnabled = true;
            this.cmbEmpStatus.Location = new System.Drawing.Point(438, 84);
            this.cmbEmpStatus.Name = "cmbEmpStatus";
            this.cmbEmpStatus.Size = new System.Drawing.Size(228, 24);
            this.cmbEmpStatus.TabIndex = 7950;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GOC_GS.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(902, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 7951;
            this.button1.Text = "&Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1024, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 44);
            this.button2.TabIndex = 7952;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 741);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFaculty";
            this.Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyList)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}