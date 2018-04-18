using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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

        public bool Isvalid(string name,string pass)
        {

            foreach (User user in UserDL.Users)
            {
                if (user.Username == name && user.Password == pass)
                {
                    return true;
                }
            }
            return false;

        }
        
        


    }
}
