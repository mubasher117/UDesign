using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    public class ComplainDL
    {
        public static List<Complaint> complaints = new List<Complaint>();
    }
}