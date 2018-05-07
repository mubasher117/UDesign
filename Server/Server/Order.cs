using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    public class Order
    {

        private bool status = false;
        private string name;
        private string address;
        private DateTime deliveryDate;
        private Shoe shoe;

        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Adress { get => address; set => address = value; }
        [DataMember]
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        [DataMember]
        public Shoe Shoe { get => shoe; set => shoe = value; }
        [DataMember]
        public bool Status { get => status; set => status = value; }

    }

}