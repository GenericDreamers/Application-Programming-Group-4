using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDongHai
{
	internal class databaseConnection
	{
		public SqlConnection cnn;
		public SqlCommand cmd;
		public DataTable dta;
		public SqlDataAdapter ada;

		public void openConnection()
		{
			//Change this to your local server name
			string sql = @"Data Source=localhost;Initial Catalog=HotelManagement;Integrated Security=True";
			cnn = new SqlConnection(sql);
			cnn.Open();
		}

		public void closeConnection() {
			if (cnn.State == ConnectionState.Open) {
				cnn.Close();
			}
		}
		public DataTable GetTable(string sql)
		{
			openConnection();
			ada = new SqlDataAdapter(sql,cnn);
			dta = new DataTable();
			ada.Fill(dta);
			closeConnection();
			return dta;
		}
		public void ExecuteCommand(string sql) {
			openConnection();
			cmd = new SqlCommand(sql,cnn);
			cmd.ExecuteNonQuery();
			closeConnection();
		}
	}
}
