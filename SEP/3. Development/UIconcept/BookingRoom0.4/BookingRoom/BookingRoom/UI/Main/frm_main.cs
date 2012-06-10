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

        private void btn_tab3_themphong_Click(object sender, EventArgs e)
        {
            Program.fthemphong.ShowDialog();
        }

        private void btn_tab3_themlau_Click(object sender, EventArgs e)
        {
            Program.fthemlau.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btn_tab2_tao_Click(object sender, EventArgs e)
        {
            Program.fthemnguoidung.ShowDialog();
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
    }
}
