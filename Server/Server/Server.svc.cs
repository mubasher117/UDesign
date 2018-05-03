using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;
using System.Collections;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServer
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }



        public bool LoginDesigner(string name, string pass)
        {
            Designer d = new Designer();
            if (name == d.Name && pass == d.Password)
            {
                return true;
            }
            return false;

        }
        public bool LoginAdmin(string name, string pass)
        {
            Admin a = new Admin();
            if (name == a.Name && pass == a.Password)
            {
                return true;
            }
            return false;

        }

        public void AddDesignInDL(System.Drawing.Image img)
        {
            DesignDL.designs.Add(img);
        }

       public void AddShoe(string m, string s, string b, string l)
        {
            Shoe sh = new Shoe();
            sh.MainColor = m;
            sh.SideColor = s;
            sh.Brand = b;
            sh.Laces = l;
            sh.Status = "Unapproved";

            //OrderDL.orders.Add(sh);


        }

        public List<Order> GetOrdersList()
        {
            return OrderDL.orders;
        }

        public string ShowShoeStatus(string m, string s, string b, string l)
        {
             
            foreach (Order o in OrderDL.orders)
            {
              /*  if (shoe.MainColor == m && shoe.SideColor == s && shoe.Brand == b && shoe.Laces == l )
                {
                    return shoe.Status;
                }*/
            }
            
            {
                return "staus not found";
            }
        }
/*
        public void SetStatus(string m, string s, string b, string l)
        {
            foreach (ot in OrderDL.orders)
            {
                if (shoe.MainColor == m && shoe.SideColor == s && shoe.Brand == b && shoe.Laces == l)
                {
                    shoe.Status = "Approved";
                }
            }
        }
        */
        public Order CreateaOrder()
        {
            Order o = new Order();
            return o;
        }

        public int GenerateId()
        {
            int id  = OrderDL.MaxId;
            OrderDL.MaxId += 1;
            return id;

        }

        public void PlaceOrder(Order o)
        {
            OrderDL.orders.Add(o);
        }

    }
}
