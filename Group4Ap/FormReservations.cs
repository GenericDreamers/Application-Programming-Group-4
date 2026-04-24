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
	public partial class FormReservations : Form
	{
		public FormReservations()
		{
			InitializeComponent();
		} 
		databaseConnection db = new databaseConnection();
		private void FormReservation_Load(object sender, EventArgs e)
		{
			showData();
			RIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ReserID");
			GIDField.DataBindings.Add("Text", dataGridView1.DataSource, "GuestID");
			RoomIDField.DataBindings.Add("Text", dataGridView1.DataSource, "RoomID");
			PSField.DataBindings.Add("Text", dataGridView1.DataSource, "PaymentStatus");
			CIField.DataBindings.Add("Text", dataGridView1.DataSource, "CheckInDate");
			COField.DataBindings.Add("Text", dataGridView1.DataSource, "CheckOutDate");

			GIDField.DataSource = db.GetTable("Select GuestID From Guests");
			GIDField.ValueMember = "GuestID";
			RoomIDField.DataSource = db.GetTable("Select RoomID From Rooms");
			RoomIDField.ValueMember = "RoomID";
		}
		private void showData()
		{
			this.reservationsTableAdapter.Fill(this.hotelManagementDataSet.Reservations);
		}

		private void btnTao_Click(object sender, EventArgs e)
		{
            int nRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
            dataGridView1.CurrentCell = dataGridView1.Rows[nRowIndex].Cells[0];

            RIDField.Text = "RES" + (nRowIndex+1).ToString();
			GIDField.Text = "";
			RoomIDField.Text = "";
			PSField.Text = "";
			CIField.Text = "";
			COField.Text = "";
			RIDField.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			String sql = String.Format("EXEC SP_THEMRESER @ReserID='{0}',@GuestID='{1}',@RoomID='{2}',@CheckInDate='{3}',@CheckOutDate='{4}', @PaymentStatus='{5}'",
			RIDField.Text, GIDField.Text, RoomIDField.Text, CIField.Text, COField.Text, PSField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String sql = String.Format("UPDATE Reservations SET GuestID = '{1}', RoomID = '{2}', CheckInDate = CONVERT(DATETIME, '{3}', 103), CheckOutDate = CONVERT(DATETIME, '{4}', 103), PaymentStatus = '{5}' WHERE ReserID = '{0}'",
				RIDField.Text, GIDField.Text, RoomIDField.Text, CIField.Text, COField.Text, PSField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = String.Format("DELETE FROM Reservations WHERE ReserID = '{0}'",
				RIDField.Text);
			db.ExecuteCommand(sql);
			showData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { return; }

            if (dataGridView1.CurrentRow.IsNewRow) { btnLuu.Enabled = true; btnSua.Enabled = false; }
            else { btnLuu.Enabled = false; btnSua.Enabled = true; }
        }
    }
}
