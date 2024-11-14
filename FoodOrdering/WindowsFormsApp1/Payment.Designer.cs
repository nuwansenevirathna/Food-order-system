namespace WindowsFormsApp1
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butdispaly = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.order1txt = new System.Windows.Forms.TextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.paymentidtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.order2txt = new System.Windows.Forms.TextBox();
            this.order3txt = new System.Windows.Forms.TextBox();
            this.qty3txt = new System.Windows.Forms.TextBox();
            this.qty2txt = new System.Windows.Forms.TextBox();
            this.qty1txt = new System.Windows.Forms.TextBox();
            this.price3txt = new System.Windows.Forms.TextBox();
            this.price2txt = new System.Windows.Forms.TextBox();
            this.price1txt = new System.Windows.Forms.TextBox();
            this.tprice3txt = new System.Windows.Forms.TextBox();
            this.tprice2txt = new System.Windows.Forms.TextBox();
            this.tprice1txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pmethodtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paidtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.baltxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.foodGridView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(566, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 155);
            this.dataGridView1.TabIndex = 37;
            // 
            // butdispaly
            // 
            this.butdispaly.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdispaly.Location = new System.Drawing.Point(640, 330);
            this.butdispaly.Name = "butdispaly";
            this.butdispaly.Size = new System.Drawing.Size(99, 44);
            this.butdispaly.TabIndex = 36;
            this.butdispaly.Text = "Dispaly";
            this.butdispaly.UseVisualStyleBackColor = false;
            this.butdispaly.Click += new System.EventHandler(this.butdispaly_Click);
            // 
            // butdelete
            // 
            this.butdelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.Location = new System.Drawing.Point(516, 330);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(99, 44);
            this.butdelete.TabIndex = 35;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = false;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butupdate
            // 
            this.butupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.Location = new System.Drawing.Point(394, 330);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(99, 44);
            this.butupdate.TabIndex = 34;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = false;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butnew
            // 
            this.butnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(269, 330);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(99, 44);
            this.butnew.TabIndex = 33;
            this.butnew.Text = "New";
            this.butnew.UseVisualStyleBackColor = false;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(148, 330);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(99, 44);
            this.butadd.TabIndex = 32;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(28, 330);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(99, 44);
            this.butsave.TabIndex = 31;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // order1txt
            // 
            this.order1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order1txt.Location = new System.Drawing.Point(31, 158);
            this.order1txt.Name = "order1txt";
            this.order1txt.Size = new System.Drawing.Size(135, 28);
            this.order1txt.TabIndex = 27;
            // 
            // cnametxt
            // 
            this.cnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnametxt.Location = new System.Drawing.Point(607, 85);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(187, 28);
            this.cnametxt.TabIndex = 26;
            // 
            // paymentidtxt
            // 
            this.paymentidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentidtxt.Location = new System.Drawing.Point(181, 85);
            this.paymentidtxt.Name = "paymentidtxt";
            this.paymentidtxt.Size = new System.Drawing.Size(187, 28);
            this.paymentidtxt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Order ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Payment Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 58);
            this.panel1.TabIndex = 19;
            // 
            // order2txt
            // 
            this.order2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order2txt.Location = new System.Drawing.Point(31, 192);
            this.order2txt.Name = "order2txt";
            this.order2txt.Size = new System.Drawing.Size(135, 28);
            this.order2txt.TabIndex = 38;
            // 
            // order3txt
            // 
            this.order3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order3txt.Location = new System.Drawing.Point(31, 226);
            this.order3txt.Name = "order3txt";
            this.order3txt.Size = new System.Drawing.Size(135, 28);
            this.order3txt.TabIndex = 39;
            // 
            // qty3txt
            // 
            this.qty3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty3txt.Location = new System.Drawing.Point(235, 226);
            this.qty3txt.Name = "qty3txt";
            this.qty3txt.Size = new System.Drawing.Size(66, 28);
            this.qty3txt.TabIndex = 42;
            // 
            // qty2txt
            // 
            this.qty2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty2txt.Location = new System.Drawing.Point(235, 192);
            this.qty2txt.Name = "qty2txt";
            this.qty2txt.Size = new System.Drawing.Size(66, 28);
            this.qty2txt.TabIndex = 41;
            // 
            // qty1txt
            // 
            this.qty1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty1txt.Location = new System.Drawing.Point(235, 158);
            this.qty1txt.Name = "qty1txt";
            this.qty1txt.Size = new System.Drawing.Size(66, 28);
            this.qty1txt.TabIndex = 40;
            // 
            // price3txt
            // 
            this.price3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price3txt.Location = new System.Drawing.Point(374, 226);
            this.price3txt.Name = "price3txt";
            this.price3txt.Size = new System.Drawing.Size(119, 28);
            this.price3txt.TabIndex = 45;
            // 
            // price2txt
            // 
            this.price2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price2txt.Location = new System.Drawing.Point(373, 192);
            this.price2txt.Name = "price2txt";
            this.price2txt.Size = new System.Drawing.Size(119, 28);
            this.price2txt.TabIndex = 44;
            // 
            // price1txt
            // 
            this.price1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price1txt.Location = new System.Drawing.Point(374, 158);
            this.price1txt.Name = "price1txt";
            this.price1txt.Size = new System.Drawing.Size(119, 28);
            this.price1txt.TabIndex = 43;
            // 
            // tprice3txt
            // 
            this.tprice3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprice3txt.Location = new System.Drawing.Point(563, 226);
            this.tprice3txt.Name = "tprice3txt";
            this.tprice3txt.Size = new System.Drawing.Size(119, 28);
            this.tprice3txt.TabIndex = 49;
            // 
            // tprice2txt
            // 
            this.tprice2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprice2txt.Location = new System.Drawing.Point(563, 192);
            this.tprice2txt.Name = "tprice2txt";
            this.tprice2txt.Size = new System.Drawing.Size(119, 28);
            this.tprice2txt.TabIndex = 48;
            // 
            // tprice1txt
            // 
            this.tprice1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprice1txt.Location = new System.Drawing.Point(563, 158);
            this.tprice1txt.Name = "tprice1txt";
            this.tprice1txt.Size = new System.Drawing.Size(119, 28);
            this.tprice1txt.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total";
            // 
            // pmethodtxt
            // 
            this.pmethodtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmethodtxt.Location = new System.Drawing.Point(1086, 155);
            this.pmethodtxt.Name = "pmethodtxt";
            this.pmethodtxt.Size = new System.Drawing.Size(183, 28);
            this.pmethodtxt.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(917, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Payment Method";
            // 
            // amounttxt
            // 
            this.amounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttxt.Location = new System.Drawing.Point(1086, 220);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(187, 28);
            this.amounttxt.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(917, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "Amount";
            // 
            // paidtxt
            // 
            this.paidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidtxt.Location = new System.Drawing.Point(1086, 287);
            this.paidtxt.Name = "paidtxt";
            this.paidtxt.Size = new System.Drawing.Size(187, 28);
            this.paidtxt.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(917, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 54;
            this.label10.Text = "Paid";
            // 
            // baltxt
            // 
            this.baltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baltxt.Location = new System.Drawing.Point(1086, 349);
            this.baltxt.Name = "baltxt";
            this.baltxt.Size = new System.Drawing.Size(187, 28);
            this.baltxt.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(917, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 22);
            this.label11.TabIndex = 56;
            this.label11.Text = "Balance";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(761, 330);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(99, 44);
            this.print.TabIndex = 58;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(917, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 59;
            this.label12.Text = "Payment Date";
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(1086, 88);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(183, 30);
            this.date2.TabIndex = 60;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            this.date2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date2_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 32);
            this.label13.TabIndex = 62;
            this.label13.Text = "Food Details";
            // 
            // foodGridView
            // 
            this.foodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Location = new System.Drawing.Point(0, 611);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.Height = 24;
            this.foodGridView.Size = new System.Drawing.Size(658, 174);
            this.foodGridView.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(698, 576);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 32);
            this.label14.TabIndex = 64;
            this.label14.Text = "Order Details";
            // 
            // orderGridView
            // 
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(677, 611);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(658, 174);
            this.orderGridView.TabIndex = 63;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 790);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.foodGridView);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.print);
            this.Controls.Add(this.baltxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.paidtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pmethodtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tprice3txt);
            this.Controls.Add(this.tprice2txt);
            this.Controls.Add(this.tprice1txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price3txt);
            this.Controls.Add(this.price2txt);
            this.Controls.Add(this.price1txt);
            this.Controls.Add(this.qty3txt);
            this.Controls.Add(this.qty2txt);
            this.Controls.Add(this.qty1txt);
            this.Controls.Add(this.order3txt);
            this.Controls.Add(this.order2txt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdispaly);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.order1txt);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.paymentidtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butdispaly;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.TextBox order1txt;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.TextBox paymentidtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox order2txt;
        private System.Windows.Forms.TextBox order3txt;
        private System.Windows.Forms.TextBox qty3txt;
        private System.Windows.Forms.TextBox qty2txt;
        private System.Windows.Forms.TextBox qty1txt;
        private System.Windows.Forms.TextBox price3txt;
        private System.Windows.Forms.TextBox price2txt;
        private System.Windows.Forms.TextBox price1txt;
        private System.Windows.Forms.TextBox tprice3txt;
        private System.Windows.Forms.TextBox tprice2txt;
        private System.Windows.Forms.TextBox tprice1txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pmethodtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paidtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox baltxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView foodGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView orderGridView;
    }
}