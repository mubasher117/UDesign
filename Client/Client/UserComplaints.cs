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
    public partial class UserComplaints : Form
    {
        private UserComplaints()
        {
            InitializeComponent();
        }
        private static UserComplaints L = null;

        public static UserComplaints GetInstance()
        {
            if (L == null)
            {
                return new UserComplaints();
            }
            return L;
        }

        private void UserComplaints_Load(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = s.GetAllComplaints();
            gvAllComplaints.DataSource = bs;
        }
    }
}
