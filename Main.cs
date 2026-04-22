using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Group4Ap
{
    public partial class Main : Form
    {
        Timer menuTimer = new Timer();
        bool isCollapsed = false;

        Timer submenuTimer = new Timer();
        bool isSubmenuCollapsed = false;

        private Form currentChildForm;

        public Main()
        {
            InitializeComponent();
            menuTimer.Interval = 5;
            menuTimer.Tick += MenuAnimation;

            submenuTimer.Interval = 5;
            submenuTimer.Tick += SubmenuAnimation;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                guna2Button5.Image = Properties.Resources.maximize;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                guna2Button5.Image = Properties.Resources.restore;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void MenuAnimation(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelMenu.Width += 20;
                if (panelMenu.Width >= 470)
                {
                    menuTimer.Stop();
                    isCollapsed = false;
                    btnMenu.Image = Properties.Resources.OutdentOpen;
                }
            }
            else
            {
                panelMenu.Width -= 20;
                if (panelMenu.Width <= 109)
                {
                    menuTimer.Stop();
                    isCollapsed = true;
                    btnMenu.Image = Properties.Resources.OutdentClose;
                }
            }
            if (panelMoreFeatures.Visible)
            {
                panelMoreFeatures.Height = 0;
                isSubmenuCollapsed = true;
                panelMoreFeatures.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnKH_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGuests());
            SetActiveButton(btnKH);
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployees());
            SetActiveButton(btnNV);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInventory());
            SetActiveButton(btnKho);

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReservations());
            SetActiveButton(btnDatPhong);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRooms());
            SetActiveButton(btnPhong);
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            openChildForm(new FormServices());
            SetActiveButton(btnDV);
        }

        private void btnSDDV_Click(object sender, EventArgs e)
        {
            openChildForm(new FormServiceOrders());
            SetActiveButton(btnSDDV);  
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPayment());
            SetActiveButton(btnThanhToan);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMiscSearch());
            SetActiveButton(btnMore);
        }

        void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            var defaultColor = Color.FromArgb(44, 57, 71);
            var activeColor = Color.FromArgb(64, 77, 91);

            var buttons = new[]
            {
                btnKH, btnNV, btnKho, btnDatPhong, btnPhong,
                btnDV, btnSDDV, btnThanhToan, btnMore, btnOtherFeatures,
                btnPhongTrong, btnDoanhThu
            };

            foreach (var btn in buttons)
            {
                btn.FillColor = defaultColor;
            }
            activeBtn.FillColor = activeColor;
        }

        private void btnOtherFeatures_Click(object sender, EventArgs e)
        {
            submenuTimer.Start();
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAvailableRooms());
            SetActiveButton(btnPhongTrong);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormServiceRevenue());
            SetActiveButton(btnDoanhThu);
        }

        private void SubmenuAnimation(object sender, EventArgs e)
        {
            int maxHeight = 180;

            if (isSubmenuCollapsed)
            {
                panelMoreFeatures.Visible = true;
                panelMoreFeatures.Height += 20;

                if (panelMoreFeatures.Height >= maxHeight)
                {
                    submenuTimer.Stop();
                    isSubmenuCollapsed = false;
                }
            }
            else
            {
                panelMoreFeatures.Height -= 20;

                if (panelMoreFeatures.Height <= 0)
                {
                    submenuTimer.Stop();
                    isSubmenuCollapsed = true;
                    panelMoreFeatures.Visible = false;
                }
            }
            
        }

        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 16;
        const int HTBOTTOMRIGHT = 17;

        const int WM_NCHITTEST = 0x84;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point pos = this.PointToClient(new Point(m.LParam.ToInt32()));

                int grip = 10; // độ dày vùng resize

                if (pos.X <= grip && pos.Y <= grip)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (pos.X >= Width - grip && pos.Y <= grip)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (pos.X <= grip && pos.Y >= Height - grip)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (pos.X >= Width - grip && pos.Y >= Height - grip)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (pos.X <= grip)
                    m.Result = (IntPtr)HTLEFT;
                else if (pos.X >= Width - grip)
                    m.Result = (IntPtr)HTRIGHT;
                else if (pos.Y <= grip)
                    m.Result = (IntPtr)HTTOP;
                else if (pos.Y >= Height - grip)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

    }
}