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
	public partial class FormServiceRevenue : Form
	{
		public FormServiceRevenue()
		{
			InitializeComponent();
		}

		private void FormServiceRevenue_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'hotelManagementDataSet.ServiceRevenue' table. You can move, or remove it, as needed.
            this.serviceRevenueTableAdapter.Fill(this.hotelManagementDataSet.ServiceRevenue);
			RIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceID");
			GIDField.DataBindings.Add("Text", dataGridView1.DataSource, "ServiceName");
			GNField.DataBindings.Add("Text", dataGridView1.DataSource, "TotalRevenue");
		}
    }
}
