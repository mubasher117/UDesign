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
    public partial class Orders : Form
    {
        private Orders()
        {
            InitializeComponent();
        }
        private static Orders L = null;

        public static Orders GetInstance()
        {
            if (L == null)
            {
                return new Orders();
            }
            return L;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = s.GetOrdersList();
            dgOrders.DataSource = bs;
        }
    }
}
