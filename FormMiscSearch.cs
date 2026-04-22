using DoDongHai;
using Group4Ap.HotelManagementDataSetTableAdapters;
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
		
		private void FormMiscSearch_Load(object sender, EventArgs e)
		{
			refreshComboBox();
			rBtnMT.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMLP.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMCV.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnBA.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
			rBtnMTT.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void refreshComboBox()
		{
			string tbl = "";
			if (rBtnMT.Checked)
			{
				tbl = "Towers";
			}
			else if (rBtnMLP.Checked)
			{
				tbl = "RoomTypes";
			}
			else if (rBtnMCV.Checked)
			{
				tbl = "Positions";
			}
			else if (rBtnMTT.Checked)
			{
				tbl = "Payments";
			}
			else if (rBtnBA.Checked)
			{
				tbl = "Accounts";
			}
			dataGridView1.DataSource = db.GetTable("Select * FROM " + tbl);
		}
		private void radioButtons_CheckedChanged(object sender, EventArgs e)
		{
			refreshComboBox();
		}
	}
}
