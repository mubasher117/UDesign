using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Designer
    {

        private string name;
        private string password;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}