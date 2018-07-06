using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorShop
{
	public partial class RefregeratorShop : Form
	{
		public SqlConnection sqlConnection = null;
		public SqlCommand command = null;		
		List<DataTable> dt = new List<DataTable>();

		private int count = 0;

		public RefregeratorShop()
		{
			InitializeComponent();		
			try
			{
				Connect();
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			tbCount.TextChanged += TbCount_TextChanged;
			cbCustomer.SelectedValueChanged += CbCustomer_SelectedValueChanged;
			cbSaler.SelectedValueChanged += CbSaler_SelectedValueChanged;
			


			ReadDB();
		}

		private void CbSaler_SelectedValueChanged(object sender, EventArgs e)
		{
			lSales.Text = (dt[1].Rows.OfType<DataRow>().First(row => row["name"] == cbSaler.SelectedItem)["saleAmount"]).ToString();
		}

		private void CbCustomer_SelectedValueChanged(object sender, EventArgs e)
		{
			lBuys.Text = (dt[0].Rows.OfType<DataRow>().First(row => row["name"] == cbCustomer.SelectedItem)["buyAmount"]).ToString();
		}

		private void TbCount_TextChanged(object sender, EventArgs e)
		{			
			try
			{
				count = int.Parse(tbCount.Text);
			}
			catch (Exception ex)
			{
				count = 0;
				MessageBox.Show(ex.Message);
			}
			int max = int.Parse((dt[2].Rows.OfType<DataRow>().First(row => row["name"] == cbItem.SelectedItem)["count"]).ToString());
			if (count == 0 || count > max)
			{
				btnDeal.Enabled = false;
			}
			else
			{
				btnDeal.Enabled = true;
			}
		}

		private void ReadDB()
		{
			SqlDataReader reader = ReadData();
			for (int i = 0; i < 5; i++)
			{
				dt.Add(new DataTable());
			}
			
			foreach (var item in dt)
			{
				item.Load(reader);
			}

			dataGridView1.DataSource = dt[4];

			foreach (DataRow row in dt[0].Rows)
			{
				cbCustomer.Items.Add(row["name"]);
			}
			foreach (DataRow row in dt[1].Rows)
			{
				cbSaler.Items.Add(row["name"]);
			}
			foreach (DataRow row in dt[2].Rows)
			{
				cbItem.Items.Add(row["name"]);
			}
			reader?.Close();

		}
		private void btnDeal_Click(object sender, EventArgs e)
		{
			int saler = (int)(dt[1].Rows.OfType<DataRow>().First(row => row["name"] == cbSaler.SelectedItem)["id_saler"]);
			int customer = (int)(dt[0].Rows.OfType<DataRow>().First(row => row["name"] == cbCustomer.SelectedItem)["id_customer"]);
			int item = (int)(dt[2].Rows.OfType<DataRow>().First(row => row["name"] == cbItem.SelectedItem)["id_items"]);
			int remain = (int)(dt[2].Rows.OfType<DataRow>().First(row => row["name"] == cbItem.SelectedItem)["count"]);
			int saleAmount = (int)(dt[1].Rows.OfType<DataRow>().First(row => row["name"] == cbSaler.SelectedItem)["saleAmount"]);
			int buyAmount = (int)(dt[0].Rows.OfType<DataRow>().First(row => row["name"] == cbCustomer.SelectedItem)["buyAmount"]);
			SqlTransaction tran = null;
			try
			{
				tran = sqlConnection.BeginTransaction();
				StringBuilder comm = new StringBuilder();
				comm.Append($"insert into Deals values('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', {saler}, {customer}, {item}, {count});");
				comm.Append($"update Items set [count] = {remain - count} where id_items = {item}");
				comm.Append($"update Salers set [saleAmount] = {saleAmount + count} where id_saler = {saler}");
				comm.Append($"update Customers set [buyAmount] = {buyAmount + count} where id_customer = {customer}");

				command.Transaction = tran;
				command.CommandText = comm.ToString();
				command.ExecuteNonQuery();
				tran.Commit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				tran.Rollback();			
			}
			ReadDB();
			
		}

		private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbPrice.Text = (dt[2].Rows.OfType<DataRow>().First(row => row["name"] == cbItem.SelectedItem))["price"].ToString();
			lbRemain.Text = (dt[2].Rows.OfType<DataRow>().First(row => row["name"] == cbItem.SelectedItem))["count"].ToString();
		}
		public SqlDataReader ReadData()
		{
			StringBuilder commands = new StringBuilder();
			commands.Append(@"SELECT * FROM Customers;");
			commands.Append(@"SELECT * FROM Salers;");
			commands.Append(@"SELECT * FROM Items;");
			commands.Append(@"SELECT * FROM Deals;");
			commands.Append(@"SELECT * FROM DealsView;");

			command = new SqlCommand(commands.ToString(), sqlConnection);

			return command.ExecuteReader();
		}
		public void Connect()
		{
			try
			{
				sqlConnection = new SqlConnection();
				sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
				sqlConnection.Open();
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
