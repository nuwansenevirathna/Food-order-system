using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Payment : Form
    {
        private PrintDocument printDocument1;

        // Declare class-level variables to store payment details
        private string paymentid, customerName, order1, order2, order3, qty1, qty2, qty3, price1, price2, price3, totalPrice1, totalPrice2, totalPrice3, amount, paid, balance, paymentMethod;
        private DateTime paymentDate;

        public Payment()
        {
            InitializeComponent();
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Add TextChanged event handlers to the quantity and price text boxes
            qty1txt.TextChanged += new EventHandler(TextBoxes_TextChanged);
            qty2txt.TextChanged += new EventHandler(TextBoxes_TextChanged);
            qty3txt.TextChanged += new EventHandler(TextBoxes_TextChanged);
            price1txt.TextChanged += new EventHandler(TextBoxes_TextChanged);
            price2txt.TextChanged += new EventHandler(TextBoxes_TextChanged);
            price3txt.TextChanged += new EventHandler(TextBoxes_TextChanged);
            paidtxt.TextChanged += new EventHandler(TextBoxes_TextChanged);
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            date2.CustomFormat = "dd/MM/yyyy";
        }

        private void date2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                date2.CustomFormat = "";
            }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPricesAndAmount();
        }

        private void CalculateTotalPricesAndAmount()
        {
            if (int.TryParse(qty1txt.Text, out int qty1) && decimal.TryParse(price1txt.Text, out decimal price1))
            {
                totalPrice1 = (qty1 * price1).ToString();
                tprice1txt.Text = totalPrice1;
            }

            if (int.TryParse(qty2txt.Text, out int qty2) && decimal.TryParse(price2txt.Text, out decimal price2))
            {
                totalPrice2 = (qty2 * price2).ToString();
                tprice2txt.Text = totalPrice2;
            }

            if (int.TryParse(qty3txt.Text, out int qty3) && decimal.TryParse(price3txt.Text, out decimal price3))
            {
                totalPrice3 = (qty3 * price3).ToString();
                tprice3txt.Text = totalPrice3;
            }

            if (decimal.TryParse(totalPrice1, out decimal totalPrice1Decimal) && decimal.TryParse(totalPrice2, out decimal totalPrice2Decimal) && decimal.TryParse(totalPrice3, out decimal totalPrice3Decimal))
            {
                amount = (totalPrice1Decimal + totalPrice2Decimal + totalPrice3Decimal).ToString();
                amounttxt.Text = amount;
            }

            if (decimal.TryParse(paidtxt.Text, out decimal paidAmount) && decimal.TryParse(amount, out decimal totalAmount))
            {
                balance = (paidAmount - totalAmount).ToString();
                baltxt.Text = balance;
            }
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            CalculateTotalPricesAndAmount();
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
               // SqlCommand cmd = new SqlCommand("INSERT INTO paymenttab (paymentid, customername, order1, order2, order3, qty1, qty2, qty3, totalprice1, totalprice2, totalprice3, amount, paid, balance, paymentmethod, paymentdate) VALUES (@paymentid, @customername, @order1, @order2, @order3, @qty1, @qty2, @qty3, @totalprice1, @totalprice2, @totalprice3, @amount, @paid, @balance, @paymentmethod, @paymentdate)", conn);
                SqlCommand cmd = new SqlCommand("INSERT INTO paymenttab (customername, order1, order2, order3, qty1, qty2, qty3, totalprice1, totalprice2, totalprice3, amount, paid, balance, paymentmethod, paymentdate) VALUES (@customername, @order1, @order2, @order3, @qty1, @qty2, @qty3, @totalprice1, @totalprice2, @totalprice3, @amount, @paid, @balance, @paymentmethod, @paymentdate)", conn);

                //cmd.Parameters.AddWithValue("@paymentid", int.Parse(paymentidtxt.Text));
                cmd.Parameters.AddWithValue("@customername", cnametxt.Text);
                cmd.Parameters.AddWithValue("@order1", order1txt.Text);
                cmd.Parameters.AddWithValue("@qty1", qty1txt.Text);
                cmd.Parameters.AddWithValue("@totalprice1", tprice1txt.Text);
                cmd.Parameters.AddWithValue("@order2", order2txt.Text);
                cmd.Parameters.AddWithValue("@qty2", qty2txt.Text);
                cmd.Parameters.AddWithValue("@totalprice2", tprice2txt.Text);
                cmd.Parameters.AddWithValue("@order3", order3txt.Text);
                cmd.Parameters.AddWithValue("@qty3", qty3txt.Text);
                cmd.Parameters.AddWithValue("@totalprice3", tprice3txt.Text);
                cmd.Parameters.AddWithValue("@amount", amounttxt.Text);
                cmd.Parameters.AddWithValue("@paid", paidtxt.Text);
                cmd.Parameters.AddWithValue("@balance", baltxt.Text);
                cmd.Parameters.AddWithValue("@paymentmethod", pmethodtxt.Text);
                cmd.Parameters.AddWithValue("@paymentdate", date2.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM paymenttab", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            paymentidtxt.Text = "";
            cnametxt.Text = "";
            order1txt.Text = "";
            qty1txt.Text = "";
            tprice1txt.Text = "";
            order2txt.Text = "";
            qty2txt.Text = "";
            tprice2txt.Text = "";
            order3txt.Text = "";
            qty3txt.Text = "";
            tprice3txt.Text = "";
            price1txt.Text = "";
            price2txt.Text = "";
            price3txt.Text = "";
            amounttxt.Text = "";
            paidtxt.Text = "";
            baltxt.Text = "";
            pmethodtxt.Text = "";
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            CalculateTotalPricesAndAmount();
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE paymenttab SET customername=@customername, order1=@order1, order2=@order2, order3=@order3, qty1=@qty1, qty2=@qty2, qty3=@qty3, totalprice1=@totalprice1, totalprice2=@totalprice2, totalprice3=@totalprice3, amount=@amount, paid=@paid, balance=@balance, paymentmethod=@paymentmethod, paymentdate=@paymentdate WHERE paymentid=@paymentid", conn);
               // cmd.Parameters.AddWithValue("@paymentid", int.Parse(paymentidtxt.Text));
                cmd.Parameters.AddWithValue("@customername", cnametxt.Text);
                cmd.Parameters.AddWithValue("@order1", order1txt.Text);
                cmd.Parameters.AddWithValue("@qty1", qty1txt.Text);
                cmd.Parameters.AddWithValue("@totalprice1", tprice1txt.Text);
                cmd.Parameters.AddWithValue("@order2", order2txt.Text);
                cmd.Parameters.AddWithValue("@qty2", qty2txt.Text);
                cmd.Parameters.AddWithValue("@totalprice2", tprice2txt.Text);
                cmd.Parameters.AddWithValue("@order3", order3txt.Text);
                cmd.Parameters.AddWithValue("@qty3", qty3txt.Text);
                cmd.Parameters.AddWithValue("@totalprice3", tprice3txt.Text);
                cmd.Parameters.AddWithValue("@amount", amounttxt.Text);
                cmd.Parameters.AddWithValue("@paid", paidtxt.Text);
                cmd.Parameters.AddWithValue("@balance", baltxt.Text);
                cmd.Parameters.AddWithValue("@paymentmethod", pmethodtxt.Text);
                cmd.Parameters.AddWithValue("@paymentdate", date2.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM paymenttab WHERE paymentid=@paymentid", conn);
                cmd.Parameters.AddWithValue("@paymentid", int.Parse(paymentidtxt.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butdispaly_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM paymenttab", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM paymenttab", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            // Load Food Table
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))

            {
                conn.Open();
                SqlDataAdapter foodAdapter = new SqlDataAdapter("SELECT * FROM foodtab", conn);
                DataTable foodTable = new DataTable();
                foodAdapter.Fill(foodTable);
                foodGridView.DataSource = foodTable;
            }

            // Load Order Table
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))

            {
                conn.Open();
                    SqlDataAdapter orderAdapter = new SqlDataAdapter("SELECT * FROM ordertab", conn);
                    DataTable orderTable = new DataTable();
                    orderAdapter.Fill(orderTable);
                    orderGridView.DataSource = orderTable;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            int paymentId = int.Parse(paymentidtxt.Text);

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A9KFENP\SQLEXPRESS;Initial Catalog=foodorderingDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM paymenttab WHERE paymentid=@paymentid", conn);
                cmd.Parameters.AddWithValue("@paymentid", paymentId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    paymentid = reader["paymentid"].ToString();
                    customerName = reader["customername"].ToString();
                    order1 = reader["order1"].ToString();
                    qty1 = reader["qty1"].ToString();
                    totalPrice1 = reader["totalprice1"].ToString();
                    order2 = reader["order2"].ToString();
                    qty2 = reader["qty2"].ToString();
                    totalPrice2 = reader["totalprice2"].ToString();
                    order3 = reader["order3"].ToString();
                    qty3 = reader["qty3"].ToString();
                    totalPrice3 = reader["totalprice3"].ToString();
                    amount = reader["amount"].ToString();
                    paid = reader["paid"].ToString();
                    balance = reader["balance"].ToString();
                    paymentMethod = reader["paymentmethod"].ToString();
                    paymentDate = (DateTime)reader["paymentdate"];

                    printDocument1.Print();
                }
                else
                {
                    MessageBox.Show("No record found for the given PaymentId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 100;
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;
            int pageWidth = e.MarginBounds.Width;
            Font printFont = new Font("Arial", 10);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            Brush printBrush = Brushes.Black;

            // Drawing heading
            e.Graphics.DrawString("Payment Invoice", headingFont, printBrush, leftMargin + (pageWidth / 2) - 50, yPos);
            yPos += 40;

            e.Graphics.DrawString("Payment Id: " + paymentid, printFont, printBrush, leftMargin, yPos); yPos += 20;
            e.Graphics.DrawString("Customer Name: " + customerName, printFont, printBrush, leftMargin, yPos); yPos += 20;
            e.Graphics.DrawString("Payment Date: " + paymentDate.ToString("dd/MM/yyyy"), printFont, printBrush, leftMargin, yPos);
            yPos += 40;

            // Drawing table headers
            e.Graphics.DrawString("Item", printFont, printBrush, leftMargin, yPos);
            e.Graphics.DrawString("Quantity", printFont, printBrush, leftMargin + 150, yPos);
            e.Graphics.DrawString("Total Price", printFont, printBrush, leftMargin + 300, yPos);
            yPos += 20;

            // Drawing table data
            e.Graphics.DrawString("Order 1: " + order1, printFont, printBrush, leftMargin, yPos);
            e.Graphics.DrawString(qty1, printFont, printBrush, leftMargin + 150, yPos);
            e.Graphics.DrawString(totalPrice1, printFont, printBrush, leftMargin + 300, yPos);
            yPos += 20;

            e.Graphics.DrawString("Order 2: " + order2, printFont, printBrush, leftMargin, yPos);
            e.Graphics.DrawString(qty2, printFont, printBrush, leftMargin + 150, yPos);
            e.Graphics.DrawString(totalPrice2, printFont, printBrush, leftMargin + 300, yPos);
            yPos += 20;

            e.Graphics.DrawString("Order 3: " + order3, printFont, printBrush, leftMargin, yPos);
            e.Graphics.DrawString(qty3, printFont, printBrush, leftMargin + 150, yPos);
            e.Graphics.DrawString(totalPrice3, printFont, printBrush, leftMargin + 300, yPos);
            yPos += 40;

            // Drawing remaining details
            e.Graphics.DrawString("Amount: " + amount, printFont, printBrush, leftMargin, yPos); yPos += 20;
            e.Graphics.DrawString("Paid: " + paid, printFont, printBrush, leftMargin, yPos); yPos += 20;
            e.Graphics.DrawString("Balance: " + balance, printFont, printBrush, leftMargin, yPos); yPos += 20;
            e.Graphics.DrawString("Payment Method: " + paymentMethod, printFont, printBrush, leftMargin, yPos); yPos += 20;
        }
    }
}
