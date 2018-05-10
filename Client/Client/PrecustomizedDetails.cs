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
    public partial class Precustomized : Form
    {
        private Precustomized()
        {
            InitializeComponent();
        }

        private static Precustomized L = null;
        public static Precustomized GetInstance()
        {
            if (L == null)
            {
                return new Precustomized();
            }
            return L;
        }
        private void PrecustomizedDetails_Load(object sender, EventArgs e)
        {

           
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home =Home.GetInstance();
            home.Show();
            this.Hide();
        }
        public void LoadPrecustomizedDetails()
        {
            localhost.Service1 s = new localhost.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = s.SeeMoreDesigns();
            gvMorePrecustomized.DataSource = b;
        }

        public void LoadPrecustomized()
        {
            PictureBox p = new PictureBox();
            p.Image = Client.Properties.Resources.StylishShoe1;

            PictureBox p2 = new PictureBox();
            p2.Image = Client.Properties.Resources.StylishShoe2;
            flPrecustomized.Controls.Add(p);
            flPrecustomized.Controls.Add(p2);
        }
    }
}
