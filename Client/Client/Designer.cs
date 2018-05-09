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
    public partial class Designer : Form
    {
        private Designer()
        {
            InitializeComponent();
        }
        private static Designer L = null;

        public static Designer GetInstance()
        {
            if (L == null)
            {
                return new Designer();
            }
            return L;
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnCreateDesign_Click(object sender, EventArgs e)
        {
            DesignerCreate h = DesignerCreate.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnUploadDesign_Click(object sender, EventArgs e)
        {

        }

        private void Designer_Load(object sender, EventArgs e)
        {

        }

        private void lnkPreCustomizedGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Precustomized login = Precustomized.GetInstance();
            login.LoadPrecustomizedDetails();
            login.Show();
            this.Hide();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
            this.Hide();
        }
    }
}
