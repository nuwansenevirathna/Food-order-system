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
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True");
            conn.Open();
            string username = txtusername.Text;
            string password = txtpassword.Text;
            SqlCommand cmd = new SqlCommand("select Username,Password from logintab where Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               // MessageBox.Show("Login Success");
               Main mn = new Main();
                mn.Show();
            }
            else 
            {
                MessageBox.Show("Invalid username or password");
            }
            conn.Close();
        }

        
    }
}
