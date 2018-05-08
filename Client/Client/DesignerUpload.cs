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
    public partial class DesignerUpload : Form
    {
        public DesignerUpload()
        {
            InitializeComponent();
        }
        private static DesignerUpload L = null;

        public static DesignerUpload GetInstance()
        {
            if (L == null)
            {
                return new DesignerUpload();
            }
            return L;
        }
        private void DesignerUpload_Load(object sender, EventArgs e)
        {
            pbSelectedImage.Image = Client.Properties.Resources.ShoeTemplate;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            dbSelectDesign.ShowDialog();
            if (dbSelectDesign.ShowDialog() == DialogResult.OK)
            {
                pbSelectedImage.Image = System.Drawing.Image.FromFile(dbSelectDesign.FileName);
            }
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }
    }
}
