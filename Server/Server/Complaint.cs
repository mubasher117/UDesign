using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    public class Complaint
    {
        private string cname;
        private string mno;
        private string email;
        private string comp;

        [DataMember]
        public string Cname { get => cname; set => cname = value; }
        [DataMember]
        public string Mno { get => mno; set => mno = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }
        [DataMember]
        public string ComplaintText { get => comp; set => comp = value; }
    }
}