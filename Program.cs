using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4Ap
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            //test functions
            //Application.Run(new FormLogin());

            //Application.Run(new FormAvailableRooms());
            //Application.Run(new FormEmployees());
            //Application.Run(new FormGuests());
            //Application.Run(new FormMiscSearch());
            Application.Run(new FormPayment()); //xac nhan thanh toan khong nhan pending
            //Application.Run(new FormReservations());
            //Application.Run(new FormRooms());
            //Application.Run(new FormServiceOrders());
            //Application.Run(new FormServiceRevenue());
            //Application.Run(new FormServices());

            //test bao cao
            //Application.Run(new FormPayment());
            //Application.Run(new FormServiceOrders());
            //Application.Run(new FormServiceRevenue());
            //Application.Run(new FormRooms());


        }
    }
}
