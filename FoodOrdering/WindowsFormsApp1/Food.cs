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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into foodtab values (@foodid,@foodname,@price,@quantity,@status)", conn);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodidtxt.Text));
            cmd.Parameters.AddWithValue("FoodName", fnametxt.Text);
            cmd.Parameters.AddWithValue("Price", pricetxt.Text);
            cmd.Parameters.AddWithValue("Quantity", qtytxt.Text);
            cmd.Parameters.AddWithValue("Status", statustxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void butadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from foodtab", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void butnew_Click(object sender, EventArgs e)
        {
            foodidtxt.Text = "";
            fnametxt.Text = "";
            pricetxt.Text = "";
            qtytxt.Text = "";
            statustxt.Text = "";
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update foodtab set foodname=@foodname,price=@price,quantity=@quantity,status=@status where foodid=@foodid", conn);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodidtxt.Text));
            cmd.Parameters.AddWithValue("FoodName", fnametxt.Text);
            cmd.Parameters.AddWithValue("Price", pricetxt.Text);
            cmd.Parameters.AddWithValue("Quantity", qtytxt.Text);
            cmd.Parameters.AddWithValue("Status", statustxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete foodtab where foodid=@foodid", conn);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodidtxt.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void butdispaly_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from foodtab", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Food_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from foodtab", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
