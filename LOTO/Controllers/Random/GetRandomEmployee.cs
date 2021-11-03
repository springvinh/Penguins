using LOTO.Models;
using System;
using System.Windows.Forms;

namespace LOTO.Controllers.Random
{
    partial class RandomController
    {
        public string GetRandomEmployee(String prize)
        {
            System.Random random = new System.Random();
            if (Employees.Count == 0)
            {
                MessageBox.Show("Danh sách nhân viên trống");
            } else if (prize == "-- Chọn giải --")
            {
                MessageBox.Show("Chọn giải để quay");
            } else
            {
                int randomIndex = random.Next(0, Employees.Count);
                Employee employee = Employees[randomIndex];

                AddSelectedEmployee(employee.Id, employee.Name, employee.Department, prize);
                Employees.Remove(Employees[randomIndex]);

                sourceEmployees.ResetBindings(false);
                sourceSelected.ResetBindings(false);

                return employee.Id.ToString();
            }

            return null;
        }
    }
}
