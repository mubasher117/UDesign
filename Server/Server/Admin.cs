using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Admin
    {

        private string name = "admin";
        private string password = "123";
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}