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

        public void Register(string name, string pass)
        {
            User u = new User();
            u.Username = name;
            u.Password = pass;

            UserDL.Users.Add(u);
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

            OrderDL.orders.Add(sh);


        }

        public List<Shoe> GetOrdersList()
        {
            return OrderDL.orders;
        }

        public string ShowShoeStatus(string m, string s, string b, string l)
        {
             
            foreach (Shoe shoe in OrderDL.orders)
            {
                if (shoe.MainColor == m && shoe.SideColor == s && shoe.Brand == b && shoe.Laces == l )
                {
                    return shoe.Status;
                }
            }
            
            {
                return "staus not found";
            }
        }

        public void SetStatus(string m, string s, string b, string l)
        {
            foreach (Shoe shoe in OrderDL.orders)
            {
                if (shoe.MainColor == m && shoe.SideColor == s && shoe.Brand == b && shoe.Laces == l)
                {
                    shoe.Status = "Approved";
                }
            }
        }


    }
}
