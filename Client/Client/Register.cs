using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.Services;
using Client.WebReferenceBroadband;

namespace Client
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            Service1 service = new Service1();
            service.Register(txtUsername.Text, txtPassword.Text);
            MessageBox.Show("registered");



           
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();


            //Daim
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
