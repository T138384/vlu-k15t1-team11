namespace BookingRoom.UI.quanlyphong_lau
{
    partial class frm_themlau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btn_frmthemlau_huy = new System.Windows.Forms.Button();
            this.btn_frmthemlau_dongy = new System.Windows.Forms.Button();
            this.txt_frmthemlau_lau = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Controls.Add(this.btn_frmthemlau_huy);
            this.groupBox12.Controls.Add(this.btn_frmthemlau_dongy);
            this.groupBox12.Controls.Add(this.textBox1);
            this.groupBox12.Controls.Add(this.txt_frmthemlau_lau);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(0, 0);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Size = new System.Drawing.Size(315, 149);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin chi tiết lầu";
            // 
            // btn_frmthemlau_huy
            // 
            this.btn_frmthemlau_huy.Location = new System.Drawing.Point(236, 101);
            this.btn_frmthemlau_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_frmthemlau_huy.Name = "btn_frmthemlau_huy";
            this.btn_frmthemlau_huy.Size = new System.Drawing.Size(70, 40);
            this.btn_frmthemlau_huy.TabIndex = 4;
            this.btn_frmthemlau_huy.Text = "Hủy";
            this.btn_frmthemlau_huy.UseVisualStyleBackColor = true;
            // 
            // btn_frmthemlau_dongy
            // 
            this.btn_frmthemlau_dongy.Location = new System.Drawing.Point(158, 101);
            this.btn_frmthemlau_dongy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_frmthemlau_dongy.Name = "btn_frmthemlau_dongy";
            this.btn_frmthemlau_dongy.Size = new System.Drawing.Size(70, 40);
            this.btn_frmthemlau_dongy.TabIndex = 4;
            this.btn_frmthemlau_dongy.Text = "Đồng ý";
            this.btn_frmthemlau_dongy.UseVisualStyleBackColor = true;
            // 
            // txt_frmthemlau_lau
            // 
            this.txt_frmthemlau_lau.Location = new System.Drawing.Point(110, 29);
            this.txt_frmthemlau_lau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_frmthemlau_lau.Name = "txt_frmthemlau_lau";
            this.txt_frmthemlau_lau.Size = new System.Drawing.Size(86, 26);
            this.txt_frmthemlau_lau.TabIndex = 1;
            this.txt_frmthemlau_lau.TextChanged += new System.EventHandler(this.txt_tab3_phong_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(63, 32);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "Lầu:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên khoa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.txt_tab3_phong_TextChanged);
            // 
            // frm_themlau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 149);
            this.Controls.Add(this.groupBox12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_themlau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lầu";
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btn_frmthemlau_huy;
        private System.Windows.Forms.Button btn_frmthemlau_dongy;
        private System.Windows.Forms.TextBox txt_frmthemlau_lau;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

    }
}