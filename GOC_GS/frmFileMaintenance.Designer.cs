
namespace GOC_GS
{
    partial class frmFileMaintenance
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
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnStrand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GOC_GS.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1119, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7968;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubjects.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubjects.Location = new System.Drawing.Point(343, 292);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(113, 65);
            this.btnSubjects.TabIndex = 7969;
            this.btnSubjects.Text = "&Subjects";
            this.btnSubjects.UseVisualStyleBackColor = false;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnSection
            // 
            this.btnSection.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSection.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSection.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSection.Location = new System.Drawing.Point(462, 292);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(113, 65);
            this.btnSection.TabIndex = 7970;
            this.btnSection.Text = "Se&ction";
            this.btnSection.UseVisualStyleBackColor = false;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFaculty.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFaculty.Location = new System.Drawing.Point(581, 292);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(113, 65);
            this.btnFaculty.TabIndex = 7971;
            this.btnFaculty.Text = "&Faculty";
            this.btnFaculty.UseVisualStyleBackColor = false;
            // 
            // btnStrand
            // 
            this.btnStrand.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStrand.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrand.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStrand.Location = new System.Drawing.Point(700, 292);
            this.btnStrand.Name = "btnStrand";
            this.btnStrand.Size = new System.Drawing.Size(113, 65);
            this.btnStrand.TabIndex = 7972;
            this.btnStrand.Text = "S&trand";
            this.btnStrand.UseVisualStyleBackColor = false;
            this.btnStrand.Click += new System.EventHandler(this.btnStrand_Click);
            // 
            // frmFileMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.btnStrand);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFileMaintenance";
            this.Text = "frmFileMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnStrand;
    }
}