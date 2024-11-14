namespace WindowsFormsApp1
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butdispaly = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.order3txt = new System.Windows.Forms.TextBox();
            this.order2txt = new System.Windows.Forms.TextBox();
            this.order1txt = new System.Windows.Forms.TextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.orderidtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 58);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._6378df0e6a668a92979cb46b_waiter_wearing_protective_face_mask_while_recommending_something_from_menu_his_customers_637285_6631;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(394, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 173);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 150);
            this.dataGridView1.TabIndex = 62;
            // 
            // butdispaly
            // 
            this.butdispaly.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdispaly.Location = new System.Drawing.Point(635, 327);
            this.butdispaly.Name = "butdispaly";
            this.butdispaly.Size = new System.Drawing.Size(99, 44);
            this.butdispaly.TabIndex = 61;
            this.butdispaly.Text = "Dispaly";
            this.butdispaly.UseVisualStyleBackColor = false;
            this.butdispaly.Click += new System.EventHandler(this.butdispaly_Click);
            // 
            // butdelete
            // 
            this.butdelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.Location = new System.Drawing.Point(516, 327);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(99, 44);
            this.butdelete.TabIndex = 60;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = false;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butupdate
            // 
            this.butupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.Location = new System.Drawing.Point(394, 327);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(99, 44);
            this.butupdate.TabIndex = 59;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = false;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butnew
            // 
            this.butnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(269, 327);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(99, 44);
            this.butnew.TabIndex = 58;
            this.butnew.Text = "New";
            this.butnew.UseVisualStyleBackColor = false;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(148, 327);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(99, 44);
            this.butadd.TabIndex = 57;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(31, 327);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(99, 44);
            this.butsave.TabIndex = 56;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // order3txt
            // 
            this.order3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order3txt.Location = new System.Drawing.Point(181, 222);
            this.order3txt.Name = "order3txt";
            this.order3txt.Size = new System.Drawing.Size(187, 28);
            this.order3txt.TabIndex = 55;
            // 
            // order2txt
            // 
            this.order2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order2txt.Location = new System.Drawing.Point(181, 188);
            this.order2txt.Name = "order2txt";
            this.order2txt.Size = new System.Drawing.Size(187, 28);
            this.order2txt.TabIndex = 54;
            // 
            // order1txt
            // 
            this.order1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order1txt.Location = new System.Drawing.Point(181, 154);
            this.order1txt.Name = "order1txt";
            this.order1txt.Size = new System.Drawing.Size(187, 28);
            this.order1txt.TabIndex = 53;
            // 
            // cnametxt
            // 
            this.cnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnametxt.Location = new System.Drawing.Point(181, 120);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(187, 28);
            this.cnametxt.TabIndex = 52;
            // 
            // orderidtxt
            // 
            this.orderidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidtxt.Location = new System.Drawing.Point(181, 86);
            this.orderidtxt.Name = "orderidtxt";
            this.orderidtxt.Size = new System.Drawing.Size(187, 28);
            this.orderidtxt.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "Order 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Order 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Order 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Order Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 63;
            this.label7.Text = "Order Date";
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(181, 256);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(187, 30);
            this.date1.TabIndex = 64;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            this.date1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date1_KeyDown);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 543);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdispaly);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.order3txt);
            this.Controls.Add(this.order2txt);
            this.Controls.Add(this.order1txt);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.orderidtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butdispaly;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.TextBox order3txt;
        private System.Windows.Forms.TextBox order2txt;
        private System.Windows.Forms.TextBox order1txt;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.TextBox orderidtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date1;
    }
}