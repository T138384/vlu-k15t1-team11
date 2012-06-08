using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookingRoom.UI.quanlyphong_lau;
using BookingRoom.UI.Main;

namespace BookingRoom
{
    static class Program
    {
        public static frm_main mainform;
        public static frm_themlau fthemlau;
        public static frm_themphong fthemphong;
        public static frm_datphong fdatphong;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fthemlau = new frm_themlau();
            fthemphong = new frm_themphong();
            fdatphong = new frm_datphong();
            Application.Run(new frm_main());
        }
    }
}
