using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into customertab values (@customerid,@customername,@phone)", conn);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(custidtxt.Text));
            cmd.Parameters.AddWithValue("CustomerName", cnametxt.Text);
            cmd.Parameters.AddWithValue("Phone", phonetxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from customertab", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            custidtxt.Text = "";
            cnametxt.Text = "";
            phonetxt.Text = "";
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customertab set customername=@customername,phone=@phone where customerid=@customerid", conn);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(custidtxt.Text));
            cmd.Parameters.AddWithValue("CustomerName", cnametxt.Text);
            cmd.Parameters.AddWithValue("Phone", phonetxt.Text); 
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete customertab where customerid=@customerid", conn);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(custidtxt.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void butdispaly_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customertab", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customertab", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
