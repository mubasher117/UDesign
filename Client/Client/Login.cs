using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.WebReferenceBroadband;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Service1 s = new Service1();
            bool valid;
            bool check;
            s.Isvalid(txtUsernsme.Text, txtPassword.Text, out valid, out check);
            if (valid)
            {
                MessageBox.Show("logged in");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}
