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
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enetr Name");
            }
            if (string.IsNullOrEmpty(txtCNIC.Text))
            {
                MessageBox.Show("Enter your CNIC");
            }
            
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter postal address");
            }
            if (!chkYes.Checked)
            {
                MessageBox.Show("Approve your status");
            }
            else
            {
                localhost.Order order = new localhost.Order();
                order.Name = txtUsername.Text;
                order.Adress = txtAddress.Text;
                order.Shoe = MyUtils.curr_shoe;
                localhost.Service1 ns = new localhost.Service1();
                ns.PlaceOrder(order);

                MessageBox.Show("Your order has been placed");
            }
                
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

        private void lnkAddComplaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddComplaint login = AddComplaint.GetInstance();
            login.Show();
            this.Hide();
        }

        private void lnkCustomize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customize login = Customize.GetInstance();
            login.Show();
            this.Hide();
        }

        private void lnkPreCustomizedGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Precustomized login = Precustomized.GetInstance();
            login.LoadPrecustomizedDetails();
            login.Show();
            this.Hide();
        }
    }
}
