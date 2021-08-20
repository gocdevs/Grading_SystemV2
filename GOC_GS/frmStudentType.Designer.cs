
namespace GOC_GS
{
    partial class frmStudentType
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
            this.btnIrreg = new System.Windows.Forms.Button();
            this.btnRegular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIrreg
            // 
            this.btnIrreg.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIrreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrreg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrreg.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIrreg.Location = new System.Drawing.Point(491, 360);
            this.btnIrreg.Name = "btnIrreg";
            this.btnIrreg.Size = new System.Drawing.Size(168, 71);
            this.btnIrreg.TabIndex = 7979;
            this.btnIrreg.Text = "&Irregular Student / Transferee";
            this.btnIrreg.UseVisualStyleBackColor = false;
            this.btnIrreg.Click += new System.EventHandler(this.btnIrreg_Click);
            // 
            // btnRegular
            // 
            this.btnRegular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegular.Location = new System.Drawing.Point(491, 248);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(168, 71);
            this.btnRegular.TabIndex = 7978;
            this.btnRegular.Text = "&Regular Student ";
            this.btnRegular.UseVisualStyleBackColor = false;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // frmStudentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 678);
            this.Controls.Add(this.btnIrreg);
            this.Controls.Add(this.btnRegular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentType";
            this.Text = "frmStudentType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIrreg;
        private System.Windows.Forms.Button btnRegular;
    }
}