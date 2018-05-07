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
    public partial class Designer_Create : Form
    {
        public Designer_Create()
        {
            InitializeComponent();
        }
        private static Designer_Create L = null;

        public static Designer_Create GetInstance()
        {
            if (L == null)
            {
                return new Designer_Create();
            }
            return L;
        }

        public string MainColor;
        public string SideColor;
        public string Laces;
        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbMain.Image = Client.Properties.Resources.ShoeTemplateFront;
            pbSide.Image = Client.Properties.Resources.ShoeTemplate;
            MessageBox.Show("Your edits has been reset");
        }
    }
}
