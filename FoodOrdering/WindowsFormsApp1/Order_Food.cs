using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Order_Food : Form
    {
        public Order_Food()
        {
            InitializeComponent();
        }

        private void Order_Food_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True";

            // Load Food Table
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter foodAdapter = new SqlDataAdapter("SELECT * FROM foodtab", conn);
                DataTable foodTable = new DataTable();
                foodAdapter.Fill(foodTable);
                foodGridView.DataSource = foodTable;
            }

            // Load Order Table
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter orderAdapter = new SqlDataAdapter("SELECT * FROM ordertab", conn);
                DataTable orderTable = new DataTable();
                orderAdapter.Fill(orderTable);
                orderGridView.DataSource = orderTable;
            }
        }
    }
}
