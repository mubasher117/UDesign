using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class PreCustomized
    {
        public static List<Shoe> Precustom = new List<Shoe>();
        public static List<Shoe> Designer = new List<Shoe>();

        public void AddToPre(Shoe shoe)
        {
            Precustom.Add(shoe);
        }
    }
}