using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Server
{
    [DataContract]
    public class Designer
    {

        private string name = "designer";
        private string password = "123";

        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Password { get => password; set => password = value; }

        
        
    }
}