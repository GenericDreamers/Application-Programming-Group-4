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
	public partial class FormEmployees : Form
	{
		public FormEmployees()
		{
			InitializeComponent();
		}
		databaseConnection db = new databaseConnection();
		private void FormEmployees_Load(object sender, EventArgs e)
		{
            showData();
			MNVField.DataBindings.Add("Text", dataGridView1.DataSource, "EmployeeID");
			TDField.DataBindings.Add("Text", dataGridView1.DataSource, "FirstName");
			TCField.DataBindings.Add("Text", dataGridView1.DataSource, "LastName");
			EmailField.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
			DTField.DataBindings.Add("Text", dataGridView1.DataSource, "PhoneNumber");
			NSField.DataBindings.Add("Text", dataGridView1.DataSource, "DateOfBirth");
			MCVField.DataBindings.Add("Text", dataGridView1.DataSource, "PositionID");
			MCVField.DataSource = db.GetTable("Select PositionID From Positions");
			MCVField.ValueMember = "PositionID";
			dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
			genderRadioSync();
		}
		private void showData()
		{
			this.employeesTableAdapter.Fill(this.hotelManagementDataSet.Employees);
		}
		private void btnTao_Click(object sender, EventArgs e)
		{
            int nRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[nRowIndex].Cells[0];

            MNVField.Text = "";
			TDField.Text = "";
			TCField.Text = "";
			EmailField.Text = "";
			DTField.Text = "";
			NSField.Text = "";
			MCVField.Text = "";
			MNVField.Focus();

        }

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("INSERT INTO Employees VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', CONVERT(DATETIME, '{5}', 103), '{6}', '{7}')",
			MNVField.Text, MCVField.Text, TDField.Text, TCField.Text, genderConverter(), NSField.Text, EmailField.Text, DTField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String sql = String.Format("UPDATE Employees SET FirstName = '{1}', LastName = '{2}', Email = '{3}', PhoneNumber = '{4}', DateOfBirth = CONVERT(DATETIME, '{5}', 103), PositionID = '{6}', Sex = '{7}' WHERE EmployeeID = '{0}'",
				MNVField.Text, TDField.Text, TCField.Text, EmailField.Text, DTField.Text, NSField.Text, MCVField.Text, genderConverter());
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = String.Format("DELETE FROM Employees WHERE EmployeeID = '{0}'",
				MNVField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private String genderConverter()
		{
			return rBtnMale.Checked ? "M" : "F";
		}
		private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
		{
			genderRadioSync();
			if (dataGridView1.CurrentRow == null) { return; }

            if (dataGridView1.CurrentRow.IsNewRow) { btnLuu.Enabled = true; btnSua.Enabled = false; }
			else {  btnLuu.Enabled = false; btnSua.Enabled = true; }
		}
		private void genderRadioSync()
		{
			if (dataGridView1.CurrentRow == null) return;
			if (dataGridView1.CurrentRow.DataBoundItem is DataRowView row)
			{
				String gender = row["Sex"].ToString().Trim();
				rBtnMale.Checked = gender.Equals("M", StringComparison.OrdinalIgnoreCase);
				rBtnFemale.Checked = gender.Equals("F", StringComparison.OrdinalIgnoreCase);
			}
		}

	}
}
