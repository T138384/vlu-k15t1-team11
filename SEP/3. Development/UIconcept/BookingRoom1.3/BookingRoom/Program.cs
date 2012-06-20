using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookingRoom.UI.quanlyphong_lau;
using BookingRoom.UI.Main;
using BookingRoom.UI.Message;
using BookingRoom.UI;

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
        public static frm_danhsachcho fdanhsachcho;
        public static frm_huyphong fhuyphong;
        //public static frm_themtaikhoan fthemtaikhoan;
        public static frm_duongdanthumuc fduongdanthumuc;
        public static frm_accountsetting faccount;
        public static frm_dangnhap fdangnhap;
        public static frm_chinhsualau fchinhsualau;
        public static frm_thememail fthememail;
        public static frm_chinhsuaemail fchinhsuaemail;
        public static frm_chinhsuathongtinlau fchinhsuathongtinlau;

        

        public static msg_nhanphong msgnhanphong;
        public static msg_error_nhapkhongdaydu errornhapkhongdaydu;
        public static msg_traphong msgtraphong;
        public static msg_datphong msgdatphong;
        public static msg_huyphong msghuyphong;
        public static msg_xoa msgxoa;
        public static msg_chinhsuathanhcong msgchinhsuathanhcong;

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
            fdanhsachcho = new frm_danhsachcho();
            fhuyphong = new frm_huyphong();
            //fthemtaikhoan = new frm_themtaikhoan();
            fduongdanthumuc = new frm_duongdanthumuc();
            faccount = new frm_accountsetting();
            fdangnhap = new frm_dangnhap();
            mainform = new frm_main();
            fchinhsualau = new frm_chinhsualau();
            fthememail = new frm_thememail();
            fchinhsuaemail = new frm_chinhsuaemail();
            fchinhsuathongtinlau = new frm_chinhsuathongtinlau();


            msgnhanphong = new msg_nhanphong();
            errornhapkhongdaydu = new msg_error_nhapkhongdaydu();
            msgtraphong = new msg_traphong();
            ftraphong = new frm_traphong();
            msgdatphong = new msg_datphong();
            msghuyphong = new msg_huyphong();
            msgxoa = new msg_xoa();
            msgchinhsuathanhcong = new msg_chinhsuathanhcong();

            

            Application.Run(fdangnhap);
        }
    }
}
