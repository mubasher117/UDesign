using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Server
{
    public class Order
    {
        private string name;
        private string address;
        private DateTime deliveryDate;
        private Image design;

        public string Name { get => name; set => name = value; }
        public string Adress { get => address; set => address = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public Image Design { get => design; set => design = value; }
    }
}