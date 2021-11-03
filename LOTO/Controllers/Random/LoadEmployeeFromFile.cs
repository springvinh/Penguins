using LOTO.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LOTO.Controllers.Random
{
    partial class RandomController
    {
        public List<Employee> LoadEmployeeFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select excel file";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Excel Sheet|*.xls;*.xlsx|All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Employees.Clear();
                Selecteds.Clear();
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(openFileDialog.FileName);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int count = xlRange.Rows.Count;

                for (int i = 1; i <= count; i++)
                {
                    int id = Int32.Parse(xlRange.Cells[i, 1].Value.ToString());
                    string name = xlRange.Cells[i, 2].Value.ToString();
                    string department = xlRange.Cells[i, 3].Value.ToString();

                    AddEmployee(id, name, department);
                }

                sourceEmployees.DataSource = Employees;
                sourceSelected.DataSource = Selecteds;
                sourceEmployees.ResetBindings(false);
                sourceSelected.ResetBindings(false);

                xlApp.Quit();
                return Employees;

            } else
            {
                MessageBox.Show("Lỗi");
            }

            sourceEmployees.DataSource = Employees;
            sourceSelected.DataSource = Selecteds;
            sourceEmployees.ResetBindings(false);
            sourceSelected.ResetBindings(false);

            return null;
        }
    }
}
