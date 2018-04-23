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
        private string brand;
        private Image logo;

        public string Sole { get => sole; set => sole = value; }
        public string MainColor { get => mainColor; set => mainColor = value; }
        public string SideColor { get => sideColor; set => sideColor = value; }
        public string Brand { get => brand; set => brand = value; }
        public Image Logo { get => logo; set => logo = value; }
    }
}