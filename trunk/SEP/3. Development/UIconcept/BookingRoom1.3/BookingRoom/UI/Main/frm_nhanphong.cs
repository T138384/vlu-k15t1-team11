using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookingRoom.UI.Main
{
    public partial class frm_nhanphong : Form
    {
        public frm_nhanphong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.msgnhanphong.ShowDialog();
            this.Close();
        }

        private void btn_frmnhanphong_xacnhan_Click(object sender, EventArgs e)
        {
            Program.msgnhanphong.ShowDialog();
            this.Close();
        }
    }
}
