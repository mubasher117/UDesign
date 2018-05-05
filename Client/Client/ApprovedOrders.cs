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
    public partial class ApprovedOrders : Form
    {
        private ApprovedOrders()
        {
            InitializeComponent();
        }
        private static ApprovedOrders L = null;

        public static ApprovedOrders GetInstance()
        {
            if (L == null)
            {
                return new ApprovedOrders();
            }
            return L;
        }
        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin a = Admin.GetInstance();
            a.Show();
            this.Hide();
        }

        private void ApprovedOrders_Load(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = s.GetApprovedOrders();
            gvApprovedOrders.DataSource = bs;            
        }
    }
}
