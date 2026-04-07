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
	public partial class FormMiscSearch : Form
	{
		public FormMiscSearch()
		{
			InitializeComponent();
		}
		databaseConnection db = new databaseConnection();
		private void btnTim_Click(object sender, EventArgs e)
		{
			String sql = "";
			if (rBtnMT.Checked)
			{
				sql = "Select * FROM Towers WHERE TowerID like '%" + SearchField.Text + "%'";
			}
			else if (rBtnMLP.Checked)
			{
				sql = "Select * FROM RoomTypes WHERE RoomTypeID like '%" + SearchField.Text + "%'";
			}
			else if (rBtnMCV.Checked)
			{
				sql = "Select * FROM Positions WHERE PositionID like '%" + SearchField.Text + "%'";
			}
			else if (rBtnMI.Checked)
			{
				sql = "Select * FROM Inventory WHERE ItemID like '%" + SearchField.Text + "%'";
			}
			else if (rBtnMTT.Checked)
			{
				sql = "Select * FROM Payments WHERE PaymentID like '%" + SearchField.Text + "%'";
			}
			dataGridView1.DataSource = db.GetTable(sql);
		}

		private void FormMiscSearch_Load(object sender, EventArgs e)
		{
			refreshComboBox();
			rBtnMT.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMLP.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMCV.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMI.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMTT.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void refreshComboBox()
		{
			if (rBtnMT.Checked)
			{
				SearchField.DataSource = db.GetTable("Select TowerID from Towers");
				SearchField.ValueMember = "TowerID";

			}
			else if (rBtnMLP.Checked)
			{
				SearchField.DataSource = db.GetTable("Select RoomTypeID from RoomTypes");
				SearchField.ValueMember = "RoomTypeID";
			}
			else if (rBtnMCV.Checked)
			{
				SearchField.DataSource = db.GetTable("Select PositionID from Positions");
				SearchField.ValueMember = "PositionID";
			}
			else if (rBtnMI.Checked)
			{
				SearchField.DataSource = db.GetTable("Select ItemID from Inventory");
				SearchField.ValueMember = "ItemID";
			}
			else if (rBtnMTT.Checked)
			{
				SearchField.DataSource = db.GetTable("Select PaymentID from Payments");
				SearchField.ValueMember = "PaymentID";

			}

		}
		private void radioButtons_CheckedChanged(object sender, EventArgs e)
		{
			refreshComboBox();
		}
	}
}
