namespace WindowsFormsApp1
{
    partial class Order_Food
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
            this.foodGridView = new System.Windows.Forms.DataGridView();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 58);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food & Order";
            // 
            // foodGridView
            // 
            this.foodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Location = new System.Drawing.Point(25, 149);
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.Height = 24;
            this.foodGridView.Size = new System.Drawing.Size(776, 170);
            this.foodGridView.TabIndex = 38;
            // 
            // orderGridView
            // 
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(25, 387);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(776, 170);
            this.orderGridView.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Food Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "Order Details";
            // 
            // Order_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.foodGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Order_Food";
            this.Text = "Order_Food";
            this.Load += new System.EventHandler(this.Order_Food_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView foodGridView;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}