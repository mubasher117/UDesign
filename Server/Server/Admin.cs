using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Admin
    {

        private string name = "mushi";
        private string password = "admin";
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

    }
}