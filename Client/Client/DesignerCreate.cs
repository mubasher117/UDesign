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
    public partial class DesignerCreate : Form
    {
        private DesignerCreate()
        {
            InitializeComponent();
        }
        private static DesignerCreate L = null;

        public static DesignerCreate GetInstance()
        {
            if (L == null)
            {
                return new DesignerCreate();
            }
            return L;
        }
        private void DesignerCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
