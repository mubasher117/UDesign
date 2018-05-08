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
            Customize login = Customize.GetInstance();
            login.Show();
            this.Hide();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
            this.Hide();
        }

        private void lnkCustomize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customize login = Customize.GetInstance();
            login.Show();
            this.Hide();

        }

        private void lnkAddComplaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddComplaint login = AddComplaint.GetInstance();
            login.Show();
            this.Hide();

        }

        private void lnkPreCustomizedGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Precustomized precustomized = Precustomized.GetInstance();
            precustomized.Show();
            this.Hide();

        }
    }
}
