using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Home : Form
    {
        private Home()
        {
            InitializeComponent();
        }
        private static Home L = null;

        public static Home GetInstance()
        {
            if (L == null)
            {
                return new Home();
            }
            return L;
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkDesignIT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
