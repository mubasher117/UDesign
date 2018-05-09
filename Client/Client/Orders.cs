using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
            
            
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            bool x = true;
            //if (e.ColumnIndex == 9)
            //{
                
                BindingSource bnd = new BindingSource();
                bnd.DataSource = s.GetShoefromOrders(e.RowIndex, x);
                gvSelectedOrder.DataSource = bnd;            //}
            
          
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin a = Admin.GetInstance();
            a.Show();
            this.Hide();
        }

        private void btnApproveAll_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            s.ApproveAllOrders();
            ApprovedOrders a = ApprovedOrders.GetInstance();
            a.Show();
            this.Hide();
            dgOrders.DataSource = null;
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            ApprovedOrders a = ApprovedOrders.GetInstance();
            a.LoadApprovedOrders();
            a.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Test t = new Test();
            t.Show();
        }

        public void LoadOrders()
        {
            dgOrders.DataSource = null;
            localhost.Service1 s = new localhost.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = s.GetOrdersList();
            dgOrders.DataSource = b;

            dgOrders.Columns[2].Visible = false;
            dgOrders.Columns[6].Visible = false;
            dgOrders.Columns[4].Visible = false;


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgOrders.Columns.Add(btn);
            btn.HeaderText = "Show Shoe";
            btn.Text = "Shoe Details";
            btn.UseColumnTextForButtonValue = true;
        }
    }
}
