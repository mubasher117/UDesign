using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Server
{
    [DataContract]
    public class OrderDL
    {
        public static List<Order> orders = new List<Order>();
    }
}