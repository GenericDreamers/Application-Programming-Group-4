using DoDongHai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4Ap
{
	public partial class FormServices : Form
	{
		public FormServices()
		{
			InitializeComponent();
		}

		databaseConnection db = new databaseConnection();
		private void btnTao_Click(object sender, EventArgs e)
		{
			MDVField.Text = "";
			TDVField.Text = "";
			GField.Text = "";
			MTField.Text = "";
			MDVField.Focus();
			dataGridView1.ClearSelection();

			int nRowIndex = dataGridView1.Rows.Count - 1;
			dataGridView1.Rows[nRowIndex].Selected = true;
			dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("INSERT INTO Services VALUES ('{0}', '{1}', '{2}', '{3}')",
			MDVField.Text, TDVField.Text, GField.Text, MTField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String sql = String.Format("UPDATE Services SET ServiceName = '{1}', Price = '{2}', Description = '{3}' WHERE ServiceID = '{0}'",
				MDVField.Text, TDVField.Text, GField.Text, MTField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = String.Format("DELETE FROM Services WHERE ServiceID = '{0}'",
				MDVField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void FormServices_Load(object sender, EventArgs e)
		{
			showData();
			MDVField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceID");
			TDVField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceName");
			GField.DataBindings.Add("Text", dataGridView1.DataSource, "Price");
			MTField.DataBindings.Add("Text", dataGridView1.DataSource, "Description");

		}
		private void showData()
		{
			this.servicesTableAdapter.Fill(this.hotelManagementDataSet.Services);
		}
	}
}
