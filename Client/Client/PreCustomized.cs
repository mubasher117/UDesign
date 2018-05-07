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
    public partial class PreCustomized : Form
    {
        private PreCustomized()
        {
            InitializeComponent();
        }
        private static PreCustomized L = null;

        public static PreCustomized GetInstance()
        {
            if (L == null)
            {
                return new PreCustomized();
            }
            return L;
        }


        private void PreCustomized_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {

            }
        }

        private void ucPredesigned1_Load(object sender, EventArgs e)
        {

        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }
    }
}
