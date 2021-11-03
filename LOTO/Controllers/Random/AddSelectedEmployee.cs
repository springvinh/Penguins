using LOTO.Models;

namespace LOTO.Controllers.Random
{
    partial class RandomController
    {
        public void AddSelectedEmployee(int id, string name, string department, string prize)
        {
            Selecteds.Add(new SelectedEmployee(id, name, department, prize)); 
        }
    }
}
