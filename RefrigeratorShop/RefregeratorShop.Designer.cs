namespace RefrigeratorShop
{
	partial class RefregeratorShop
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
			this.label2 = new System.Windows.Forms.Label();
			this.cbSaler = new System.Windows.Forms.ComboBox();
			this.cbCustomer = new System.Windows.Forms.ComboBox();
			this.cbItem = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCount = new System.Windows.Forms.TextBox();
			this.lbPrice = new System.Windows.Forms.Label();
			this.btnDeal = new System.Windows.Forms.Button();
			this.lbRemain = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lBuys = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lSales = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Saler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 90);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer";
			// 
			// cbSaler
			// 
			this.cbSaler.FormattingEnabled = true;
			this.cbSaler.Location = new System.Drawing.Point(141, 11);
			this.cbSaler.Margin = new System.Windows.Forms.Padding(6);
			this.cbSaler.Name = "cbSaler";
			this.cbSaler.Size = new System.Drawing.Size(219, 32);
			this.cbSaler.TabIndex = 2;
			// 
			// cbCustomer
			// 
			this.cbCustomer.FormattingEnabled = true;
			this.cbCustomer.Location = new System.Drawing.Point(141, 85);
			this.cbCustomer.Margin = new System.Windows.Forms.Padding(6);
			this.cbCustomer.Name = "cbCustomer";
			this.cbCustomer.Size = new System.Drawing.Size(219, 32);
			this.cbCustomer.TabIndex = 3;
			// 
			// cbItem
			// 
			this.cbItem.FormattingEnabled = true;
			this.cbItem.Location = new System.Drawing.Point(141, 168);
			this.cbItem.Margin = new System.Windows.Forms.Padding(6);
			this.cbItem.Name = "cbItem";
			this.cbItem.Size = new System.Drawing.Size(219, 32);
			this.cbItem.TabIndex = 5;
			this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 174);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Item";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 262);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Count";
			// 
			// tbCount
			// 
			this.tbCount.Location = new System.Drawing.Point(141, 259);
			this.tbCount.Margin = new System.Windows.Forms.Padding(6);
			this.tbCount.Name = "tbCount";
			this.tbCount.Size = new System.Drawing.Size(219, 29);
			this.tbCount.TabIndex = 7;
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Location = new System.Drawing.Point(461, 174);
			this.lbPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(20, 24);
			this.lbPrice.TabIndex = 8;
			this.lbPrice.Text = "0";
			// 
			// btnDeal
			// 
			this.btnDeal.BackColor = System.Drawing.SystemColors.Control;
			this.btnDeal.Enabled = false;
			this.btnDeal.Location = new System.Drawing.Point(28, 358);
			this.btnDeal.Margin = new System.Windows.Forms.Padding(6);
			this.btnDeal.Name = "btnDeal";
			this.btnDeal.Size = new System.Drawing.Size(138, 42);
			this.btnDeal.TabIndex = 10;
			this.btnDeal.Text = "Deal";
			this.btnDeal.UseVisualStyleBackColor = false;
			this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
			// 
			// lbRemain
			// 
			this.lbRemain.AutoSize = true;
			this.lbRemain.Location = new System.Drawing.Point(473, 262);
			this.lbRemain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbRemain.Name = "lbRemain";
			this.lbRemain.Size = new System.Drawing.Size(20, 24);
			this.lbRemain.TabIndex = 11;
			this.lbRemain.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(372, 262);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 24);
			this.label5.TabIndex = 12;
			this.label5.Text = "Remain";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(372, 174);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 24);
			this.label6.TabIndex = 13;
			this.label6.Text = "Price";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(372, 90);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 24);
			this.label7.TabIndex = 16;
			this.label7.Text = "Buys";
			// 
			// lBuys
			// 
			this.lBuys.AutoSize = true;
			this.lBuys.Location = new System.Drawing.Point(461, 90);
			this.lBuys.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lBuys.Name = "lBuys";
			this.lBuys.Size = new System.Drawing.Size(20, 24);
			this.lBuys.TabIndex = 15;
			this.lBuys.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(372, 17);
			this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 24);
			this.label9.TabIndex = 18;
			this.label9.Text = "Sales";
			// 
			// lSales
			// 
			this.lSales.AutoSize = true;
			this.lSales.Location = new System.Drawing.Point(461, 17);
			this.lSales.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lSales.Name = "lSales";
			this.lSales.Size = new System.Drawing.Size(20, 24);
			this.lSales.TabIndex = 17;
			this.lSales.Text = "0";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-2, 409);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(721, 397);
			this.dataGridView1.TabIndex = 19;
			// 
			// RefregeratorShop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(723, 818);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lSales);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lBuys);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbRemain);
			this.Controls.Add(this.btnDeal);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.tbCount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbItem);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbCustomer);
			this.Controls.Add(this.cbSaler);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "RefregeratorShop";
			this.Text = "RefregeratorShop";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbSaler;
		private System.Windows.Forms.ComboBox cbCustomer;
		private System.Windows.Forms.ComboBox cbItem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCount;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Button btnDeal;
		private System.Windows.Forms.Label lbRemain;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lBuys;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lSales;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}