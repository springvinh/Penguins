using LOTO.Models;

namespace LOTO.Controllers.Auth
{

    enum State
    {
        Auth,
        Unauth
    }

    static partial class AuthController
    {
        static public User user;
        static public State state = State.Unauth;
        static public string path = "USERS.INI";
    }
}
