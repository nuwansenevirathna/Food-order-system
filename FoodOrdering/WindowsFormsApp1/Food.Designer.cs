namespace WindowsFormsApp1
{
    partial class Food
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.foodidtxt = new System.Windows.Forms.TextBox();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.statustxt = new System.Windows.Forms.TextBox();
            this.butsave = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butdispaly = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // foodidtxt
            // 
            this.foodidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodidtxt.Location = new System.Drawing.Point(181, 76);
            this.foodidtxt.Name = "foodidtxt";
            this.foodidtxt.Size = new System.Drawing.Size(187, 28);
            this.foodidtxt.TabIndex = 6;
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(181, 121);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(187, 28);
            this.fnametxt.TabIndex = 7;
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(181, 171);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(187, 28);
            this.pricetxt.TabIndex = 8;
            // 
            // qtytxt
            // 
            this.qtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytxt.Location = new System.Drawing.Point(181, 217);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(187, 28);
            this.qtytxt.TabIndex = 9;
            // 
            // statustxt
            // 
            this.statustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustxt.Location = new System.Drawing.Point(181, 261);
            this.statustxt.Name = "statustxt";
            this.statustxt.Size = new System.Drawing.Size(187, 28);
            this.statustxt.TabIndex = 10;
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.Location = new System.Drawing.Point(31, 317);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(99, 44);
            this.butsave.TabIndex = 12;
            this.butsave.Text = "Save";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(148, 317);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(99, 44);
            this.butadd.TabIndex = 13;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butnew
            // 
            this.butnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(269, 317);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(99, 44);
            this.butnew.TabIndex = 14;
            this.butnew.Text = "New";
            this.butnew.UseVisualStyleBackColor = false;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // butupdate
            // 
            this.butupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.Location = new System.Drawing.Point(394, 317);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(99, 44);
            this.butupdate.TabIndex = 15;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = false;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butdelete
            // 
            this.butdelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.Location = new System.Drawing.Point(516, 317);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(99, 44);
            this.butdelete.TabIndex = 16;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = false;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butdispaly
            // 
            this.butdispaly.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butdispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdispaly.Location = new System.Drawing.Point(635, 317);
            this.butdispaly.Name = "butdispaly";
            this.butdispaly.Size = new System.Drawing.Size(99, 44);
            this.butdispaly.TabIndex = 17;
            this.butdispaly.Text = "Dispaly";
            this.butdispaly.UseVisualStyleBackColor = false;
            this.butdispaly.Click += new System.EventHandler(this.butdispaly_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Blues_Kitchen_Brixton_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(394, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 213);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdispaly);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statustxt);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.foodidtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox foodidtxt;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.TextBox statustxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butdispaly;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}