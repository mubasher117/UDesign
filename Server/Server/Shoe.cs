using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Runtime.Serialization;

namespace Server
{
    public class Shoe
    {
        private string mainColor;

        private string sideColor;

        private string laces;
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


    }
}