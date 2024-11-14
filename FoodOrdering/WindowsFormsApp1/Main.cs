using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Food fd = new Food();
            fd.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer cr = new Customer();
            cr.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order or = new Order();
            or.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment pt = new Payment();
            pt.Show();
        }
    }
}
