namespace WindowsFormsApp1
{
    partial class Customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butdispaly = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.custidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 187);
            this.dataGridView1.TabIndex = 37;
            // 
            // butdispaly
            // 
            this.butdispaly.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdispaly.Location = new System.Drawing.Point(635, 292);
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
            this.butdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.Location = new System.Drawing.Point(516, 292);
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
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.Location = new System.Drawing.Point(394, 292);
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
            this.butnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(269, 292);
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
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(148, 292);
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
            this.butsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(31, 292);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(99, 44);
            this.butsave.TabIndex = 31;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // phonetxt
            // 
            this.phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(181, 231);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(187, 28);
            this.phonetxt.TabIndex = 27;
            // 
            // cnametxt
            // 
            this.cnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnametxt.Location = new System.Drawing.Point(181, 161);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(187, 28);
            this.cnametxt.TabIndex = 26;
            // 
            // custidtxt
            // 
            this.custidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custidtxt.Location = new System.Drawing.Point(181, 86);
            this.custidtxt.Name = "custidtxt";
            this.custidtxt.Size = new System.Drawing.Size(187, 28);
            this.custidtxt.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 58);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.customerservicewaiter;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(394, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 173);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdispaly);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.cnametxt);
            this.Controls.Add(this.custidtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butdispaly;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.TextBox custidtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}