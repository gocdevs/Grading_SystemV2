
namespace GOC_GS
{
    partial class frmFacultySetUp
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
            this.btnLoads = new System.Windows.Forms.Button();
            this.btnLoadSection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoads
            // 
            this.btnLoads.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoads.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoads.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoads.Location = new System.Drawing.Point(499, 240);
            this.btnLoads.Name = "btnLoads";
            this.btnLoads.Size = new System.Drawing.Size(168, 71);
            this.btnLoads.TabIndex = 7976;
            this.btnLoads.Text = "&Faculty Loads";
            this.btnLoads.UseVisualStyleBackColor = false;
            this.btnLoads.Click += new System.EventHandler(this.btnLoads_Click);
            // 
            // btnLoadSection
            // 
            this.btnLoadSection.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSection.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadSection.Location = new System.Drawing.Point(499, 352);
            this.btnLoadSection.Name = "btnLoadSection";
            this.btnLoadSection.Size = new System.Drawing.Size(168, 71);
            this.btnLoadSection.TabIndex = 7977;
            this.btnLoadSection.Text = "&Faculty Section Loads";
            this.btnLoadSection.UseVisualStyleBackColor = false;
            this.btnLoadSection.Click += new System.EventHandler(this.btnLoadSection_Click);
            // 
            // frmFacultySetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.btnLoadSection);
            this.Controls.Add(this.btnLoads);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacultySetUp";
            this.Text = "frmFacultySetUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoads;
        private System.Windows.Forms.Button btnLoadSection;
    }
}