using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOC_GS
{
    class CrystalReportConnection
    {
        public static string DSN = null;
        public static string HOST = null;
        public static string DATABASE = null;
        public static string USERNAME = null;
        public static string PASSWORD = null;

        private static CrystalReportConnection instance = null;
        private static readonly object padlock = new object();

        public static CrystalReportConnection Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CrystalReportConnection();
                    }
                    return instance;
                }
            }
        }

        public void SetConnection(ref ReportDocument rpt)
        {
            try
            {
                //create connection info
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;

                //update connection string base on  database config
                crConnectionInfo.ServerName = DSN;
                crConnectionInfo.DatabaseName = DATABASE;
                crConnectionInfo.UserID = USERNAME;
                crConnectionInfo.Password = PASSWORD;
                CrTables = rpt.Database.Tables;

                //CrTables = rpt.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }
            }

            catch (CrystalReportsException ex)
            {
                MessageBox.Show("Error: Cannot connect to server" + ex.Message.ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
