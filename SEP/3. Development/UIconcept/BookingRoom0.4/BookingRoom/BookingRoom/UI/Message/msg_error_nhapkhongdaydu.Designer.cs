namespace BookingRoom.UI.Message
{
    partial class msg_error_nhapkhongdaydu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_msgerrornhapkhongdu_xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin bạn nhập không đầy đủ\r\nXin vui lòng nhập vào đủ những ô bắt buộc\r\n";
            // 
            // btn_msgerrornhapkhongdu_xacnhan
            // 
            this.btn_msgerrornhapkhongdu_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_msgerrornhapkhongdu_xacnhan.Location = new System.Drawing.Point(114, 74);
            this.btn_msgerrornhapkhongdu_xacnhan.Name = "btn_msgerrornhapkhongdu_xacnhan";
            this.btn_msgerrornhapkhongdu_xacnhan.Size = new System.Drawing.Size(94, 46);
            this.btn_msgerrornhapkhongdu_xacnhan.TabIndex = 1;
            this.btn_msgerrornhapkhongdu_xacnhan.Text = "xác nhận";
            this.btn_msgerrornhapkhongdu_xacnhan.UseVisualStyleBackColor = true;
            // 
            // msg_error_nhapkhongdaydu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 127);
            this.Controls.Add(this.btn_msgerrornhapkhongdu_xacnhan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "msg_error_nhapkhongdaydu";
            this.Text = "msg_error_nhapkhongdaydu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_msgerrornhapkhongdu_xacnhan;
    }
}