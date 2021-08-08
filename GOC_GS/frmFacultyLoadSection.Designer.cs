
namespace GOC_GS
{
    partial class frmFacultyLoadSection
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
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvFacultyLoads = new System.Windows.Forms.DataGridView();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyLoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(1035, 57);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(106, 28);
            this.btnRemoveAll.TabIndex = 8035;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1004, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 28);
            this.btnUpdate.TabIndex = 8034;
            this.btnUpdate.Text = "&Update Section";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvFacultyLoads
            // 
            this.dgvFacultyLoads.AllowUserToAddRows = false;
            this.dgvFacultyLoads.AllowUserToDeleteRows = false;
            this.dgvFacultyLoads.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacultyLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultyLoads.Location = new System.Drawing.Point(15, 92);
            this.dgvFacultyLoads.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacultyLoads.Name = "dgvFacultyLoads";
            this.dgvFacultyLoads.RowHeadersVisible = false;
            this.dgvFacultyLoads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyLoads.Size = new System.Drawing.Size(1127, 544);
            this.dgvFacultyLoads.TabIndex = 8033;
            this.dgvFacultyLoads.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultyLoads_CellContentClick);
            this.dgvFacultyLoads.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultyLoads_CellEnter);
            this.dgvFacultyLoads.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvFacultyLoads_EditingControlShowing);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFaculty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFaculty.Location = new System.Drawing.Point(1103, 640);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(17, 19);
            this.lblFaculty.TabIndex = 8029;
            this.lblFaculty.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(925, 640);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 19);
            this.label10.TabIndex = 8028;
            this.label10.Text = "No. of Subject Assigned: ";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GOC_GS.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1121, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8015;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 8013;
            this.label4.Text = "Search Faculty Name:";
            // 
            // txtStudent
            // 
            this.txtStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent.Location = new System.Drawing.Point(170, 57);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(238, 27);
            this.txtStudent.TabIndex = 8036;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            this.txtStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudent_KeyPress);
            // 
            // frmFacultyLoadSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.dgvFacultyLoads);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacultyLoadSection";
            this.Text = "frmFacultyLoadSection";
            this.Load += new System.EventHandler(this.frmFacultyLoadSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyLoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvFacultyLoads;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudent;
    }
}