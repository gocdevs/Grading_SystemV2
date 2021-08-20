using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();           
        }

        public void Credential()
        {
            CrystalReport_Connection.HOST = GOC_GS.Config.DB_HOST;
            CrystalReport_Connection.DSN = GOC_GS.Config.DSN;
            CrystalReport_Connection.database = GOC_GS.Config.DB_NAME;
            CrystalReport_Connection.username = GOC_GS.Config.DB_USER;
            CrystalReport_Connection.password = GOC_GS.Config.DB_PASSWORD;
        }

        #region Registration Form Report
        public string LRN { get; set; }       
        public void PrintRegForm()
        {
            //Report Connection
            Credential();
            ReportDocument reportData = new ReportDocument();
            reportData.Load(Application.StartupPath + "Reports/StudentList.rpt");
            //reportData.Load("C:/Users/SERVER/Documents/GitHub/Grading_SystemV2/GOC_GS/StudentList.rpt");
        

            CrystalReport_Connection.Instance.SetConnection(ref reportData);
            //Report Parameter
            reportData.SetParameterValue("Section", txtSection.Text);

            MyReportViewer1.ReportSource = reportData;
            MyReportViewer1.Refresh();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            PrintRegForm();
        }

        public string gradeLevel, section, subject, semester,teacher_name;

        public void Grades()
        {
            //Report Connection
            Credential();
            ReportDocument reportData = new ReportDocument();
            //reportData.Load(Application.StartupPath + "/Reports/rptAssessment.rpt");
            reportData.Load("C:/Users/SERVER/Documents/GitHub/Grading_SystemV2/GOC_GS/FinalSemetralGrades.rpt");


            CrystalReport_Connection.Instance.SetConnection(ref reportData);
            //Report Parameter
            reportData.SetParameterValue("GradeLevel", gradeLevel);
            reportData.SetParameterValue("Subject", subject);
            reportData.SetParameterValue("Section", section);
            reportData.SetParameterValue("Semester", semester);
            reportData.SetParameterValue("Subject_Teacher","CHRISTIAN MANUEL");
            reportData.SetParameterValue("Adviser", "EFRAIM G. BASILIO");
            reportData.SetParameterValue("Principal", "DR. REX I. IGOY, RGC");
            reportData.SetParameterValue("EvalOfficer", "JOCELYN V. DEANG");
            MyReportViewer1.ReportSource = reportData;
            MyReportViewer1.Refresh();
        }
    }
}
