using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO.Controllers.Auth
{
    static partial class AuthController 
    {
        static public State SignOut()
        {
            user = null;
            state = State.Unauth;
            return state;
        }
    }
}
