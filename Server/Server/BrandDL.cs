using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class BrandDL
    {
        public static List<Brand> brands = new List<Brand>();
        public void AddBrand(Brand brand)
        {
            brands.Add(brand);
        }
    }
}