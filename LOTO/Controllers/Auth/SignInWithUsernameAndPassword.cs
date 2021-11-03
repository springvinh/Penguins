using LOTO.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO.Controllers.Auth
{
    static partial class AuthController
    {
        static public State SignInWithUsernameAndPassword(string username, string password)
        {
            List<String> userLines = File.ReadAllLines(path).ToList();

            foreach (String userLine in userLines)
            {
                string[] data = userLine.Split(';');

                if(data[2] == username)
                {

                    if(data[3] == password)
                    {
                        User match = new User(Int32.Parse(data[0]), data[1], data[2], data[3]);

                        user = match;
                        state = State.Auth;
                        return State.Auth;

                    } else
                    {
                        MessageBox.Show("Sai mật khẩu");
                        return State.Unauth;
                    }

                }
            }

            return State.Unauth;
        }
    }
}
