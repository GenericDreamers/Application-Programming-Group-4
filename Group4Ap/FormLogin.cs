using DoDongHai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4Ap
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		databaseConnection db = new databaseConnection();

		private void btnLogin_Click(object sender, EventArgs e)
		{
			db.openConnection();
			string a = usernameField.Text;
			string b = passwordField.Text;
			string sql = "Select LinkedID From Accounts Where Username = '" + a + "' AND Pass ='" + b + "'";
			DataTable result = db.GetTable(sql);
			if (result != null && result.Rows.Count > 0)
			{
				LoginInfo.ID = (string) result.Rows[0][0];
				if (LoginInfo.ID.Contains("E"))
				{
					LoginInfo.Role = "Employee";
				}
				else
				{
					LoginInfo.Role = "Guest";
				}
				MessageBox.Show("Đăng nhập thành công.");
				//frmMain frm = new frmMain();
				//frm.Show();
				//temp going to FormInventory for testing
				FormInventory f = new FormInventory();
				f.Show();
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại");
			}
		}
	}
}
