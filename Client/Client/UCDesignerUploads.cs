using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ucDUpload : UserControl
    {
        private ucDUpload()
        {
            InitializeComponent();
        }



        public ucDUpload(Image i, string l)
        {
            InitializeComponent();
            this.pbShoe.Image = i;
            this.lblShoe.Text = l;
        }
        private void lblShoe_Click(object sender, EventArgs e)
        {

        }

        private void ucDUpload_Load(object sender, EventArgs e)
        {

        }
    }
}
