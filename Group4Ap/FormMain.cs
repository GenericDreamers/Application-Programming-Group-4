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
	public partial class FormMain : Form
	{
		private int childFormNumber = 0;

		public FormMain()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Window " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStrip.Visible = toolBarToolStripMenuItem.Checked;
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormGuests f = new FormGuests
			{
				MdiParent = this
			};
			f.Show();
		}

		private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormEmployees f = new FormEmployees
			{
				MdiParent = this
			};
			f.Show();
		}

		private void inventoryListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormInventory f = new FormInventory
			{
				MdiParent = this
			};
			f.Show();
		}

		private void reservationListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormReservations f = new FormReservations
			{
				MdiParent = this
			};
			f.Show();
		}

		private void roomListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRooms f = new FormRooms
			{
				MdiParent = this
			};
			f.Show();
		}

		private void serviceListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormServices f = new FormServices
			{
				MdiParent = this
			};
			f.Show();
		}

		private void serviceOrderListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormServiceOrders f = new FormServiceOrders
			{
				MdiParent = this
			};
			f.Show();
		}

		private void otherInformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMiscSearch f = new FormMiscSearch
			{
				MdiParent = this
			};
			f.Show();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			FormLogin f = new FormLogin();
			f.ShowDialog();
			if (LoginInfo.ID == "")
			{
				MessageBox.Show("Bạn cần đăng nhập để dùng hệ thống.");
				Application.Exit();
			}
		}

		private void danhSáchThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormPayment f = new FormPayment
			{
				MdiParent = this
			};
			f.Show();
		}

		private void availableRoomsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAvailableRooms f = new FormAvailableRooms
			{
				MdiParent = this
			};
			f.Show();
		}

		private void serviceRevenueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormServiceRevenue f = new FormServiceRevenue
			{
				MdiParent = this
			};
			f.Show();
		}
	}
}
