using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookingRoom
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.fdatphong.ShowDialog();
        }

       
        //private void btn_tab3_luuchinhsuaphong(object sender, EventArgs e)
        //{
        //    Program.msgxoa.ShowDialog();
        //}

        private void btn_tab3_themlau_Click(object sender, EventArgs e)
        {
            Program.fthemlau.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btn_tab2_tao_Click(object sender, EventArgs e)
        {
            //Program.fthemnguoidung.ShowDialog();
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            Program.fnhanphong.ShowDialog();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Program.ftraphong.ShowDialog();
        }

        private void btn_doiphong_Click(object sender, EventArgs e)
        {
            Program.fdoiphong.ShowDialog();
            
        }

        private void btn_tab1_datphongdungngay_Click(object sender, EventArgs e)
        {
            Program.fdatphong.ShowDialog();
        }

        private void btn_tab1_traphong_Click(object sender, EventArgs e)
        {
            Program.ftraphong.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.fdanhsachcho.ShowDialog();
        }

        private void btn_huyphong_Click(object sender, EventArgs e)
        {
            Program.fhuyphong.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           // Program.fthemtaikhoan.ShowDialog();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.fduongdanthumuc.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Program.fduongdanthumuc.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Program.faccount.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Program.fdangnhap.Visible = true;           
            Program.mainform.Visible = false;
            //Program.fdangnhap.Visible = true;
            
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = Program.fdangnhap.getUsername();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_tab3_luuchinhsualau_Click(object sender, EventArgs e)
        {
            Program.fchinhsuathongtinlau.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Program.fthememail.ShowDialog();
        }

        private void chỉnhSửaMẫuSẵnCóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.fchinhsuaemail.ShowDialog();
        }

        private void btn_tab2_xoa_Click(object sender, EventArgs e)
        {
            Program.msgxoa.ShowDialog();
        }

        private void btn_tab3_themphong_Click_1(object sender, EventArgs e)
        {
            Program.fthemphong.ShowDialog();
        }

        private void btn_tab3_luuchinhsuaphong_Click(object sender, EventArgs e)
        {
            Program.msgchinhsuathanhcong.ShowDialog();
        }

        private void btn_tab3_xoaphong_Click(object sender, EventArgs e)
        {
            Program.msgxoa.ShowDialog();
        }

        private void btn_tab2_dongy_Click(object sender, EventArgs e)
        {
            Program.msgchinhsuathanhcong.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.msgxoa.ShowDialog();
        }

        private void btn_tab3_xoalau_Click(object sender, EventArgs e)
        {
            Program.msgxoa.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất khỏi hệ thống không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = true;
                Program.fdangnhap.Visible = true;
                Program.mainform.Visible = false;
            }
            else
            {
                e.Cancel = true;             
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Program.msgxoa.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Program.msgchinhsuathanhcong.ShowDialog();
        }
    }
}
