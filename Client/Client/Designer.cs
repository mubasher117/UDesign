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
        public Designer()
        {
            InitializeComponent();
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
    }
}
