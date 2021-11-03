using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LOTO.Controllers.Random
{
    partial class RandomController
    {
        public void ExportToExcel() {
            DateTime time = DateTime.Now;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Excel Sheet|*.xls;*.xlsx|All Files(*.*)|*.*";
            saveFileDialog.FileName = String.Format("Result-{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}.xls", time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second);
        
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook workbook = xlApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;

                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Test";

                worksheet.Cells[1, 1] = "ID";
                worksheet.Cells[1, 2] = "Name";
                worksheet.Cells[1, 3] = "Department";
                worksheet.Cells[1, 4] = "Prize";

                for (int i = 0; i < Selecteds.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = Selecteds[i].Id;
                    worksheet.Cells[i + 2, 2] = Selecteds[i].Name;
                    worksheet.Cells[i + 2, 3] = Selecteds[i].Department;
                    worksheet.Cells[i + 2, 4] = Selecteds[i].Prize;
                }

                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlApp.Quit();
            }
        }
    }
}
