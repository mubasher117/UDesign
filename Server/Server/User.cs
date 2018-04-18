using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class User
    {
        string username;
        string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
