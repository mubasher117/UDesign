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
    public partial class UserInfo : Form
    {
        private UserInfo()
        {
            InitializeComponent();
        }
        private static UserInfo L = null;

        public static UserInfo GetInstance()
        {
            if (L == null)
            {
                return new UserInfo();
            }
            return L;
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            localhost.Order order = new localhost.Order();
            order.Name = txtUsername.Text;
            order.Adress = txtCNIC.Text;
            order.Shoe = MyUtils.curr_shoe;
            localhost.Service1 ns = new localhost.Service1();
            ns.PlaceOrder(order);
                
        }

        private void UserInfo_Load(object sender, EventArgs e)
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
