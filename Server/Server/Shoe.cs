using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Server
{
    public class Shoe
    {
        private string sole;
        private string mainColor;
        private string sideColor;
        private bool laces = false;
        private string brand;
        private Image logo;

        public string Sole { get => sole; set => sole = value; }
        public string MainColor { get => mainColor; set => mainColor = value; }
        public string SideColor { get => sideColor; set => sideColor = value; }
        public string Brand { get => brand; set => brand = value; }
        public Image Logo { get => logo; set => logo = value; }
        public bool Laces { get => laces; set => laces = value; }

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
        public void AddColor(string mcolor, string scolor)
        {
            this.mainColor = mcolor;
            this.sideColor = scolor;
        }
        public void AddLogo(Image logo)
        {
            this.logo = logo;
        }
        public void AddBrand(string brand)
        {
            this.brand = brand;
        }
    }
}