﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookingRoom.UI.Main
{
    public partial class frm_traphong : Form
    {
        public frm_traphong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.msgtraphong.ShowDialog();
            this.Close();
        }
    }
}