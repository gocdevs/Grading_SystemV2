
namespace GOC_GS
{
    partial class frmGradeInput
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadStud = new System.Windows.Forms.Button();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveGrades = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradelevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GOC_GS.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1118, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7991;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnLoadStud);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.cmbGradeLevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSubject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbTerm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 54);
            this.panel1.TabIndex = 7995;
            // 
            // btnLoadStud
            // 
            this.btnLoadStud.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadStud.Location = new System.Drawing.Point(853, 13);
            this.btnLoadStud.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadStud.Name = "btnLoadStud";
            this.btnLoadStud.Size = new System.Drawing.Size(85, 28);
            this.btnLoadStud.TabIndex = 1059;
            this.btnLoadStud.Text = "Search";
            this.btnLoadStud.UseVisualStyleBackColor = true;
            this.btnLoadStud.Click += new System.EventHandler(this.btnLoadStud_Click);
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            "11",
            "12"});
            this.cmbGradeLevel.Location = new System.Drawing.Point(95, 14);
            this.cmbGradeLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(53, 26);
            this.cmbGradeLevel.TabIndex = 1046;
            this.cmbGradeLevel.SelectedIndexChanged += new System.EventHandler(this.cmbGradeLevel_SelectedIndexChanged);
            this.cmbGradeLevel.Click += new System.EventHandler(this.cmbGradeLevel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(352, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1052;
            this.label1.Text = "Subject:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(418, 14);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(159, 26);
            this.cmbSubject.TabIndex = 1051;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(163, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1050;
            this.label2.Text = "Section:";
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGrades.Location = new System.Drawing.Point(1014, 74);
            this.btnSaveGrades.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(125, 26);
            this.btnSaveGrades.TabIndex = 1058;
            this.btnSaveGrades.Text = "Submit Grades";
            this.btnSaveGrades.UseVisualStyleBackColor = true;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(229, 14);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(112, 26);
            this.cmbSection.TabIndex = 1049;
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(591, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 1054;
            this.label5.Text = "Term:";
            // 
            // cmbTerm
            // 
            this.cmbTerm.BackColor = System.Drawing.Color.White;
            this.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Items.AddRange(new object[] {
            "1st",
            "2nd"});
            this.cmbTerm.Location = new System.Drawing.Point(642, 15);
            this.cmbTerm.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(73, 26);
            this.cmbTerm.TabIndex = 1053;
            this.cmbTerm.SelectedIndexChanged += new System.EventHandler(this.cmbTerm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 1048;
            this.label3.Text = "Grade Level:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1009, 13);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 28);
            this.btnPrint.TabIndex = 1060;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvGrades);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 546);
            this.panel2.TabIndex = 7996;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1326, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1057;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.IDNo,
            this.StudentName,
            this.subjectCode,
            this.units,
            this.firstQ,
            this.secondQ,
            this.average,
            this.remarks,
            this.Term,
            this.gradelevel,
            this.section1});
            this.dgvGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrades.GridColor = System.Drawing.Color.Gray;
            this.dgvGrades.Location = new System.Drawing.Point(0, 0);
            this.dgvGrades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersVisible = false;
            this.dgvGrades.Size = new System.Drawing.Size(1126, 546);
            this.dgvGrades.TabIndex = 1056;
            this.dgvGrades.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellEndEdit);
            this.dgvGrades.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvGrades_EditingControlShowing);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // IDNo
            // 
            this.IDNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDNo.HeaderText = "IDNo";
            this.IDNo.Name = "IDNo";
            this.IDNo.Width = 66;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            // 
            // subjectCode
            // 
            this.subjectCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.Width = 108;
            // 
            // units
            // 
            this.units.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.units.HeaderText = "Units";
            this.units.Name = "units";
            this.units.Visible = false;
            // 
            // firstQ
            // 
            this.firstQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.firstQ.HeaderText = "Quarter Grade";
            this.firstQ.Name = "firstQ";
            this.firstQ.Width = 116;
            // 
            // secondQ
            // 
            this.secondQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.secondQ.HeaderText = "Quarter Grade";
            this.secondQ.Name = "secondQ";
            this.secondQ.Width = 116;
            // 
            // average
            // 
            this.average.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.average.HeaderText = "Average";
            this.average.Name = "average";
            this.average.Width = 87;
            // 
            // remarks
            // 
            this.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.remarks.HeaderText = "Remarks";
            this.remarks.Name = "remarks";
            this.remarks.Width = 90;
            // 
            // Term
            // 
            this.Term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Term.HeaderText = "Term";
            this.Term.Name = "Term";
            this.Term.Visible = false;
            // 
            // gradelevel
            // 
            this.gradelevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gradelevel.HeaderText = "Level";
            this.gradelevel.Name = "gradelevel";
            this.gradelevel.Visible = false;
            // 
            // section1
            // 
            this.section1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.section1.HeaderText = "Section";
            this.section1.Name = "section1";
            this.section1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1627, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 17);
            this.label17.TabIndex = 1024;
            this.label17.Text = "__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1668, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 1023;
            this.label4.Text = "X";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNum.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum.Location = new System.Drawing.Point(1121, 655);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(14, 15);
            this.lblNum.TabIndex = 8031;
            this.lblNum.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1021, 655);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 8030;
            this.label10.Text = "No. of Students:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 1060;
            this.label6.Text = "Section Active:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(145, 74);
            this.lblSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(0, 19);
            this.lblSection.TabIndex = 8032;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(772, 15);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(73, 26);
            this.cmbGender.TabIndex = 1060;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(730, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 1060;
            this.label7.Text = "Sex:";
            // 
            // frmGradeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveGrades);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradeInput";
            this.Text = "frmGradeInput";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveGrades;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoadStud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn average;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradelevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn section1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label7;
    }
}