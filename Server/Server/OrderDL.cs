using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class OrderDL
    {

        public static List<Order> orders = new List<Order>();

        public void AddToCArt(Order purchase)
        {
            orders.Add(purchase);
        }
        public List<Order> DownloadOrdersList()
        {
            return orders;
        }
    }
}