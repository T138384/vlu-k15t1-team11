using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookingRoom.UI.quanlyphong_lau;
using BookingRoom.UI.Main;
using BookingRoom.UI.Message;

namespace BookingRoom
{
    static class Program
    {
        public static frm_main mainform;
        public static frm_themlau fthemlau;
        public static frm_themphong fthemphong;
        public static frm_datphong fdatphong;
        public static frm_themnguoidung fthemnguoidung;
        public static frm_nhanphong fnhanphong;
        public static frm_traphong ftraphong;
        public static frm_doiphong fdoiphong;
       


        public static msg_nhanphong msgnhanphong;
        public static msg_error_nhapkhongdaydu errornhapkhongdaydu;
        public static msg_traphong msgtraphong;
        public static msg_datphong msgdatphong;

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
            fthemnguoidung = new frm_themnguoidung();
            fnhanphong = new frm_nhanphong();
            fdoiphong = new frm_doiphong();

            msgnhanphong = new msg_nhanphong();
            errornhapkhongdaydu = new msg_error_nhapkhongdaydu();
            msgtraphong = new msg_traphong();
            ftraphong = new frm_traphong();
            msgdatphong = new msg_datphong();

            

            Application.Run(new frm_main());
        }
    }
}
