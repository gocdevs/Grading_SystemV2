using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace GOC_GS.Models
{
    class StudentProfile
    {
        Microsoft.Office.Interop.Excel.Application application;
        Microsoft.Office.Interop.Excel.Workbook workbook;
        Microsoft.Office.Interop.Excel.Worksheet worksheet;
        Microsoft.Office.Interop.Excel.Range range;

        protected string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void openFile()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            if (openFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFD.FileName;
            }
        }

        public void importFile(DataGridView dgv)
        {
            try
            {
                if (filePath != null)
                {
                    application = new Microsoft.Office.Interop.Excel.Application();
                    workbook = application.Workbooks.Open(filePath);
                    worksheet = workbook.Worksheets["sheet1"];
                    range = worksheet.UsedRange;

                    //load datagrid
                    int xlRow;
                    dgv.Rows.Clear();
                    for (xlRow = 2; xlRow <= range.Rows.Count; xlRow++)
                    {
                        dgv.Rows.Add(range.Cells[xlRow, 1].Text,
                                    range.Cells[xlRow, 2].Text,
                                    range.Cells[xlRow, 3].Text,
                                    range.Cells[xlRow, 4].Text,
                                    range.Cells[xlRow, 5].Text,
                                    range.Cells[xlRow, 6].Text,
                                    range.Cells[xlRow, 7].Text,
                                    range.Cells[xlRow, 8].Text,
                                    range.Cells[xlRow, 9].Text
                                    );
                    }
                    //end load datagrid

                    workbook.Close();
                    application.Quit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.ToString(), "Grading System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
