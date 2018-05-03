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
    public partial class AddComplaint : Form
    {
        private AddComplaint()
        {
            InitializeComponent();
        }
        private static AddComplaint L = null;

        public static AddComplaint GetInstance()
        {
            if (L == null)
            {
                return new AddComplaint();
            }
            return L;
        }
        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = Home.GetInstance();
            h.Show();
            this.Hide();
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            localhost.Complaint complaint = new localhost.Complaint();
            complaint.Cname = txtName.Text;
            complaint.Mno = txtMobileNo.Text;
            complaint.Email = txtEmail.Text;
            complaint.ComplaintText = txtComplaint.Text;

            
        }
    }
}
