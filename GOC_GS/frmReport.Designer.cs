
namespace GOC_GS
{
    partial class frmReport
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
            this.MyReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MyReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentList1 = new GOC_GS.StudentList();
            this.SuspendLayout();
            // 
            // MyReportViewer
            // 
            this.MyReportViewer.ActiveViewIndex = -1;
            this.MyReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MyReportViewer.Name = "MyReportViewer";
            this.MyReportViewer.Size = new System.Drawing.Size(150, 150);
            this.MyReportViewer.TabIndex = 0;
            // 
            // MyReportViewer1
            // 
            this.MyReportViewer1.ActiveViewIndex = -1;
            this.MyReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.MyReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.MyReportViewer1.Name = "MyReportViewer1";
            this.MyReportViewer1.Size = new System.Drawing.Size(1317, 766);
            this.MyReportViewer1.TabIndex = 0;
            this.MyReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(510, 13);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(186, 20);
            this.txtSection.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 766);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.MyReportViewer1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MyReportViewer;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer MyReportViewer1;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Button button1;
        private StudentList StudentList1;
    }
}