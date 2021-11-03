using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO.Models
{
    class Employee
    {
        private int id;
        private string name;
        private string department;

        public Employee() {}

        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
    }
}
