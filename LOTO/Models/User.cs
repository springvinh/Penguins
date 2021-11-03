using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO.Models
{
    class User
    {
        private int id;
        private string username;
        private string name;
        private string password;

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Username = username;
            Name = name;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
