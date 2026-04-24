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
	public partial class FormInventory : Form
	{
		public FormInventory()
		{
			InitializeComponent();
			dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
		}
		databaseConnection db = new databaseConnection();
		private decimal originalInStock;
		private void btnTao_Click(object sender, EventArgs e)
		{
            int nRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[nRowIndex].Cells[0];

            MVPField.Text = "";
            TVPField.Text = "";
            TKField.Text = "";
            PPUField.Text = "";
            DVField.Text = "";
            LCField.Text = "";
            MVPField.Focus();
        }

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("INSERT INTO Inventory VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', CONVERT(DATETIME, '{5}', 103))",
			MVPField.Text, TVPField.Text, TKField.Text, DVField.Text, PPUField.Text, DateTime.Now);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (LoginInfo.Role != "Employee"){
				MessageBox.Show("You do not have permission to update this item.");
				return;
			}
			String sql = String.Format("UPDATE Inventory SET ItemName = '{1}', PricePerUnit = '{2}', Unit = '{3}' WHERE ItemID = '{0}'",
				MVPField.Text, TVPField.Text, PPUField.Text, DVField.Text);
			db.ExecuteCommand(sql);

			//If stock is changed, calculate the difference and put it in InventoryChanges
			decimal newInStock = Convert.ToDecimal(TKField.Text);
			decimal difference = newInStock - originalInStock;
			if (difference != 0)
			{
				MessageBox.Show($"InStock changed by: {difference}\nOld: {originalInStock}, New: {newInStock}");
				string type;
				if (difference > 0)
				{
					type = "Addition";	
				}
				else{
					type = "Removal";
					difference = 0 - difference; //Quantity on InventoryChanges need to be positive
				}
				string insert = String.Format("EXEC SP_THEMINVENCHANGE " +
				"@ChangeDate='{0}', @ChangeType='{1}', @EmployeeID='{2}',@ItemID='{3}',@Quantity='{4}',@Notes='{5}'",
				DateTime.Now, type, LoginInfo.ID, MVPField.Text, difference, "Added through FormInventory");
				db.ExecuteCommand(insert);
			}
			showData();
			StoreOriginalInStock();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			var confirm = MessageBox.Show("Bạn có chắc rằng bạn muốn xóa thông tin vật phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
			if (confirm == DialogResult.Yes) {
				String sql = String.Format("DELETE FROM InventoryChanges WHERE ItemID = '{0}'", 
						MVPField.Text);
				db.ExecuteCommand(sql);
				sql = String.Format("DELETE FROM Inventory WHERE ItemID = '{0}'",
					MVPField.Text);
				db.ExecuteCommand(sql);

				showData();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void FormInventory_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Inventory' table. You can move, or remove it, as needed.
			showData();
			MVPField.DataBindings.Add("Text", dataGridView1.DataSource, "ItemID");
			TVPField.DataBindings.Add("Text", dataGridView1.DataSource, "ItemName");
			TKField.DataBindings.Add("Text", dataGridView1.DataSource, "InStock");
			PPUField.DataBindings.Add("Text", dataGridView1.DataSource, "PricePerUnit");
			DVField.DataBindings.Add("Text", dataGridView1.DataSource, "Unit");
			LCField.DataBindings.Add("Text", dataGridView1.DataSource, "LastChange");
			StoreOriginalInStock();

			dataGridView1.SelectionChanged += (s, ev) => StoreOriginalInStock();
		}
		private void showData()
		{
			this.inventoryTableAdapter.Fill(this.hotelManagementDataSet.Inventory);
		}
		private void StoreOriginalInStock()
		{
			if (dataGridView1.CurrentRow != null && !DBNull.Value.Equals(dataGridView1.CurrentRow.Cells[2].Value))
			{
				originalInStock = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value ?? 0);
			}
		}
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { return; }

            if (dataGridView1.CurrentRow.IsNewRow) { btnLuu.Enabled = true; btnSua.Enabled = false; }
            else { btnLuu.Enabled = false; btnSua.Enabled = true; }
        }
    }
}
