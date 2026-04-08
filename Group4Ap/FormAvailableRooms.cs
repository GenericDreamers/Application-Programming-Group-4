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
	public partial class FormAvailableRooms : Form
	{
		public FormAvailableRooms()
		{
			InitializeComponent();
		}
		databaseConnection db = new databaseConnection();

		private void FormAvailableRooms_Load(object sender, EventArgs e)
		{
			var data = db.GetTable("Select RoomTypeName From RoomTypes");

			// Add "All" as the first row
			var newRow = data.NewRow();
			newRow["RoomTypeName"] = "Tất cả";
			data.Rows.InsertAt(newRow, 0);

			RTNField.DataSource = data;
			RTNField.ValueMember = "RoomTypeName";
		}

		private void btnTao_Click(object sender, EventArgs e)
		{
			string RTN = RTNField.Text;
			if (RTN == "Tất cả") { RTN = "*"; }

			if (DField.Text == ""){
				MessageBox.Show("Xin vui lòng điền một số vào dòng Số ngày khách ở.");
				return;
			}

			dataGridView1.DataSource = db.GetTable(String.Format("Exec CheckAvailableRooms '{0}', {1}, '{2}'"
			, CIField.Text, DField.Text, RTN));
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			RTNField.Text = "";
			CIField.Text = "";
			DField.Text = "";

			RTNField.Focus();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
