using LOTO.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LOTO.Controllers.Random
{
    partial class RandomController
    {
        private List<Employee> employees;
        private List<SelectedEmployee> selecteds;
        public BindingSource sourceEmployees = new BindingSource();
        public BindingSource sourceSelected = new BindingSource();

        public List<Employee> Employees { get => employees; set => employees = value; }
        public List<SelectedEmployee> Selecteds { get => selecteds; set => selecteds = value; }

        public RandomController()
        {
            Employees = new List<Employee>();
            Selecteds = new List<SelectedEmployee>();

            sourceEmployees.DataSource = Employees;
            sourceSelected.DataSource = Selecteds;
        }

    }
}
