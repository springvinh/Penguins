using LOTO.Models;

namespace LOTO.Controllers.Random
{
    partial class RandomController
    {
        public void AddEmployee(int id, string name, string department)
        {
            Employees.Add(new Employee(id, name, department));
        }
    }
}
