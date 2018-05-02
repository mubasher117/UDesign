using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;

namespace Server
{
    [DataContract]
    public class Shoe
    {
     
        private string mainColor;
     
        private string sideColor;
     
        private string laces ;
        private string brand;
        private string status;
        
        //private Image logo;
        
        [DataMember]
        public string MainColor { get => mainColor; set => mainColor = value; }
        [DataMember]
        public string SideColor { get => sideColor; set => sideColor = value; }
        [DataMember]
        public string Brand { get => brand; set => brand = value; }
        //public Image Logo { get => logo; set => logo = value; }
        [DataMember]
        public string Laces { get => laces; set => laces = value; }
        public string Status { get => status; set => status = value; }


        /*
        public Image AddTemp(Image image)
        {
            return image;
        }
        public void AddSole(string sole)
        {
            this.sole = sole;
        }
        public void AddLace()
        {
            this.laces = true;
        }
        public void AddColor(Color mcolor, Color scolor)
        {
            this.mainColor = mcolor;
            this.sideColor = scolor;
        }
        public void AddLogo(Image logo)
        {
            //this.logo = logo;
        }
        public void AddBrand(string brand)
        {
            this.brand = brand;
        }
        */
    }
}