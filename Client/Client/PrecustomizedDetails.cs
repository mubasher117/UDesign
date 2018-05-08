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
    public partial class PrecustomizedDetails : Form
    {
        public PrecustomizedDetails()
        {
            InitializeComponent();
        }

        private static PrecustomizedDetails L = null;
        public static PrecustomizedDetails GetInstance()
        {
            if (L == null)
            {
                return new PrecustomizedDetails();
            }
            return L;
        }
        private void PrecustomizedDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
