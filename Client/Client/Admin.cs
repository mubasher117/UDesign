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
    public partial class Admin : Form
    {
        private Admin()
        {
            InitializeComponent();
        }
        private static Admin L = null;

        public static Admin GetInstance()
        {
            if (L == null)
            {
                return new Admin();
            }
            return L;
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders h = Orders.GetInstance();
            h.LoadOrders();
            h.Show();
            this.Hide();
        }

        private void btnDesignerDesign_Click(object sender, EventArgs e)
        {
            DesignerDesign h = DesignerDesign.GetInstance();
            h.Show();
            this.Hide();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            UserComplaints h = UserComplaints.GetInstance();
            h.Show();
            this.Hide();
        }

        private void lnkPreCustomizedGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Precustomized h = Precustomized.GetInstance();
            h.LoadPrecustomizedDetails();
            h.Show();
            this.Hide();
        }
    }
}
