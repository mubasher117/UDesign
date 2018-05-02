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
    public partial class DesignerDesign : Form
    {
        private DesignerDesign()
        {
            InitializeComponent();
        }
        private static DesignerDesign L = null;

        public static DesignerDesign GetInstance()
        {
            if (L == null)
            {
                return new DesignerDesign();
            }
            return L;
        }
        private void DesignerDesign_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

        }

        private void flDesignerDesign_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin h = Admin.GetInstance();
            h.Show();
            this.Hide();
        }
    }
}
