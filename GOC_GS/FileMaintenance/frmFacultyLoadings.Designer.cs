
namespace GOC_GS
{
    partial class frmFacultyLoadings
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
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStrand = new System.Windows.Forms.ComboBox();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFacultyName = new System.Windows.Forms.DataGridView();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.dgvFacultyLoads = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvNewSubjects = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyLoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyName.Location = new System.Drawing.Point(11, 61);
            this.txtFacultyName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtFacultyName.Multiline = true;
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(269, 28);
            this.txtFacultyName.TabIndex = 7964;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 7963;
            this.label4.Text = "Search Faculty Name:";
            // 
            // cmbStrand
            // 
            this.cmbStrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStrand.FormattingEnabled = true;
            this.cmbStrand.Location = new System.Drawing.Point(744, 61);
            this.cmbStrand.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbStrand.Name = "cmbStrand";
            this.cmbStrand.Size = new System.Drawing.Size(120, 27);
            this.cmbStrand.TabIndex = 7971;
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            "11",
            "12"});
            this.cmbGradeLevel.Location = new System.Drawing.Point(643, 61);
            this.cmbGradeLevel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(75, 27);
            this.cmbGradeLevel.TabIndex = 7970;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(740, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 7969;
            this.label7.Text = "Strand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(639, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 7968;
            this.label6.Text = "Grade Level:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.cmbSemester.Location = new System.Drawing.Point(881, 61);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(120, 27);
            this.cmbSemester.TabIndex = 7974;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(877, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 7973;
            this.label3.Text = "Semester:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(304, 61);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSubjectName.Multiline = true;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(287, 28);
            this.txtSubjectName.TabIndex = 7978;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(301, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 7977;
            this.label1.Text = "Search Subject Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 649);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 7979;
            this.label5.Text = "No. of Faculty: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(121, 649);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 7980;
            this.label8.Text = "Count: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(479, 649);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 7983;
            this.label9.Text = "Count: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(301, 649);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 19);
            this.label10.TabIndex = 7982;
            this.label10.Text = "No. of Subject Assigned: ";
            // 
            // dgvFacultyName
            // 
            this.dgvFacultyName.AllowUserToAddRows = false;
            this.dgvFacultyName.AllowUserToDeleteRows = false;
            this.dgvFacultyName.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacultyName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultyName.Location = new System.Drawing.Point(11, 97);
            this.dgvFacultyName.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacultyName.Name = "dgvFacultyName";
            this.dgvFacultyName.ReadOnly = true;
            this.dgvFacultyName.RowHeadersVisible = false;
            this.dgvFacultyName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyName.Size = new System.Drawing.Size(269, 548);
            this.dgvFacultyName.TabIndex = 7985;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(1131, 97);
            this.dgvSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(835, 197);
            this.dgvSubjects.TabIndex = 7986;
            this.dgvSubjects.Visible = false;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // dgvFacultyLoads
            // 
            this.dgvFacultyLoads.AllowUserToAddRows = false;
            this.dgvFacultyLoads.AllowUserToDeleteRows = false;
            this.dgvFacultyLoads.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacultyLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultyLoads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3});
            this.dgvFacultyLoads.Location = new System.Drawing.Point(304, 372);
            this.dgvFacultyLoads.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacultyLoads.Name = "dgvFacultyLoads";
            this.dgvFacultyLoads.ReadOnly = true;
            this.dgvFacultyLoads.RowHeadersVisible = false;
            this.dgvFacultyLoads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyLoads.Size = new System.Drawing.Size(835, 273);
            this.dgvFacultyLoads.TabIndex = 7987;
            this.dgvFacultyLoads.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultyLoads_CellContentClick);
            this.dgvFacultyLoads.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvFacultyLoads_ColumnAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Faculty Id ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "FullName ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Subject Code";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Grade Level";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Strand ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Semester";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Subject Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GOC_GS.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1119, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7967;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(937, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 28);
            this.btnSave.TabIndex = 8011;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(1040, 333);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(97, 28);
            this.btnRemoveAll.TabIndex = 8012;
            this.btnRemoveAll.Text = "&Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1052, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 28);
            this.btnLoad.TabIndex = 8013;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvNewSubjects
            // 
            this.dgvNewSubjects.AllowUserToAddRows = false;
            this.dgvNewSubjects.AllowUserToDeleteRows = false;
            this.dgvNewSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvNewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvNewSubjects.Location = new System.Drawing.Point(304, 97);
            this.dgvNewSubjects.Name = "dgvNewSubjects";
            this.dgvNewSubjects.ReadOnly = true;
            this.dgvNewSubjects.RowHeadersVisible = false;
            this.dgvNewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewSubjects.Size = new System.Drawing.Size(833, 226);
            this.dgvNewSubjects.TabIndex = 8014;
            this.dgvNewSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewSubjects_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "id ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Subject Code";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Subject Name";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Grade Level";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Subject Type";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Strand";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Semester";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // frmFacultyLoadings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.dgvNewSubjects);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvFacultyLoads);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.dgvFacultyName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStrand);
            this.Controls.Add(this.cmbGradeLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFacultyName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacultyLoadings";
            this.Text = "frmFacultyLoadings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyLoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ComboBox cmbStrand;
        private System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvFacultyName;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.DataGridView dgvFacultyLoads;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvNewSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}