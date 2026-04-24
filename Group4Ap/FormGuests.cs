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
	public partial class FormGuests : Form
	{
		public FormGuests()
		{
			InitializeComponent();
		}
		databaseConnection db = new databaseConnection();
		private void btnTao_Click(object sender, EventArgs e)
		{
            int nRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[nRowIndex].Cells[0];

            MKField.Text = "";
			TDField.Text = "";
			TCField.Text = "";
			EmailField.Text = "";
			DTField.Text = "";
			DCField.Text = "";
			MKField.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("INSERT INTO Guests VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
			MKField.Text, TDField.Text, TCField.Text, EmailField.Text, DTField.Text, DCField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String sql = String.Format("UPDATE Guests SET FirstName = '{1}', LastName = '{2}', Email = '{3}', PhoneNumber = '{4}', Address = '{5}' WHERE GuestID = '{0}'",
				MKField.Text, TDField.Text, TCField.Text, EmailField.Text, DTField.Text, DCField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = String.Format("DELETE FROM Guests WHERE GuestID = '{0}'",
				MKField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void FormGuest_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'hotelManagementDataSet.Guests' table. You can move, or remove it, as needed.
			showData();
			MKField.DataBindings.Add("Text", dataGridView1.DataSource, "GuestID");
			TDField.DataBindings.Add("Text", dataGridView1.DataSource, "FirstName");
			TCField.DataBindings.Add("Text", dataGridView1.DataSource, "LastName");
			EmailField.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
			DTField.DataBindings.Add("Text", dataGridView1.DataSource, "PhoneNumber");
			DCField.DataBindings.Add("Text", dataGridView1.DataSource, "Address");
		}
		private void showData()
		{
			this.guestsTableAdapter.Fill(this.hotelManagementDataSet.Guests);
		}

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { return; }

            if (dataGridView1.CurrentRow.IsNewRow) { btnLuu.Enabled = true; btnSua.Enabled = false; }
            else { btnLuu.Enabled = false; btnSua.Enabled = true; }
        }
    }
}
