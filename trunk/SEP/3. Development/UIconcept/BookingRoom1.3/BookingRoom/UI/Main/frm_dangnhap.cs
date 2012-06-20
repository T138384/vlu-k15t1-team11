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
    
    public partial class frm_dangnhap : Form
    {
        
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                
                Program.mainform.Show();
                Program.fdangnhap.Visible = false;
               

            }
            if (textBox1.Text == "bravo" && textBox2.Text == "bravo")
            {

                Program.mainform.Show();
                Program.fdangnhap.Visible = false;


            }
        }
    }
}
