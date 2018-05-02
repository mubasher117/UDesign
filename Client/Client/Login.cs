using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.localhost;


namespace Client
{
    public partial class Login : Form
    {
        private Login()
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
            if (rbtnDesigner.Checked)
            {
                s.LoginDesigner(txtUsernsme.Text, txtPassword.Text, out valid, out check);
                if (valid)
                {
                    MessageBox.Show("logged in");
                    DesignUpload d = DesignUpload.GetInstance();
                    d.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("invalid");
                }
            }
            else if (rbtnAdmin.Checked)
            {
                s.LoginAdmin(txtUsernsme.Text, txtPassword.Text, out valid, out check);
                if (valid)
                {
                    MessageBox.Show("logged in");
                    Admin d = Admin.GetInstance();
                    d.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("invalid");
                }

            }

        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }
    }
}
