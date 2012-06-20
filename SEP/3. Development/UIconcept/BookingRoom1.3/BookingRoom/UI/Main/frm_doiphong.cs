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
    public partial class frm_doiphong : Form
    {
        public frm_doiphong()
        {
            InitializeComponent();
        }

        private void btn_frmdoiphong_dongy_Click(object sender, EventArgs e)
        {
            Program.msgdatphong.ShowDialog();
            this.Close();
        }
    }
}
