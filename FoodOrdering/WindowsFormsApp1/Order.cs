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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            date1.CustomFormat = "dd/mm/yyyy";
        }

        private void date1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                date1.CustomFormat = "";
            }
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into ordertab values (@orderid,@customername,@order1,@order2,@order3,@orderdate)", conn);
            cmd.Parameters.AddWithValue("@OrderId", int.Parse(orderidtxt.Text));
            cmd.Parameters.AddWithValue("CustomerName", cnametxt.Text);
            cmd.Parameters.AddWithValue("Order1", order1txt.Text);
            cmd.Parameters.AddWithValue("Order2", order2txt.Text);
            cmd.Parameters.AddWithValue("Order3", order3txt.Text);
            cmd.Parameters.AddWithValue("OrderDate", date1.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void butadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from ordertab", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            orderidtxt.Text = "";
            cnametxt.Text = "";
            order1txt.Text = "";
            order2txt.Text = "";
            order3txt.Text = "";
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update ordertab set customername=@customername,order1=@order1,order2=@order2,order3=@order3,orderdate=@orderdate where orderid=@orderid", conn);
            cmd.Parameters.AddWithValue("@OrderId", int.Parse(orderidtxt.Text));
            cmd.Parameters.AddWithValue("CustomerName", cnametxt.Text);
            cmd.Parameters.AddWithValue("Order1", order1txt.Text);
            cmd.Parameters.AddWithValue("Order2", order2txt.Text);
            cmd.Parameters.AddWithValue("Order3", order3txt.Text);
            cmd.Parameters.AddWithValue("OrderDate", date1.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete ordertab where orderid=@orderid", conn);
            cmd.Parameters.AddWithValue("@OrderId", int.Parse(orderidtxt.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butdispaly_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ordertab", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ordertab", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
