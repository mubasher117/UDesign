﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Collections;
namespace Server
{
    [DataContract]
    public class OrderDL
    {
        [DataMember]
        public static List<Order> orders = new List<Order>();
        [DataMember]
        public static ArrayList ids = new ArrayList();
        public static int MaxId = 12568;

        
    }
}