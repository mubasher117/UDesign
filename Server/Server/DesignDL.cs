using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Collections;

namespace Server
{
    [DataContract]
    public class DesignDL
    {
        public static ArrayList designs = new ArrayList();
        public static List<Shoe> MoreDesigns = new List<Shoe>();

        
        public void AddToMoreDesigns(Shoe shoe)
        {
            DesignDL.MoreDesigns.Add(shoe);
        }
        public List<Shoe> GetMoreDesigns()
        {
            return DesignDL.MoreDesigns;
        }

    }

}