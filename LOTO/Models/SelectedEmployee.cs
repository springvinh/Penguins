using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO.Models
{
    class SelectedEmployee
    {
        private int id;
        private string name;
        private string department;
        private string prize;

        public SelectedEmployee(int id, string name, string department, string prize)
        {
            Id = id;
            Name = name;
            Department = department;
            Prize = prize;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Prize { get => prize; set => prize = value; }
    }
}
