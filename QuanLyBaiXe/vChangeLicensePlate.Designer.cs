namespace QuanLyBaiXe
{
    partial class vChangeLicensePlate
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
            this.pic_AnhXeCanSua = new System.Windows.Forms.PictureBox();
            this.lb_ThongBao1 = new System.Windows.Forms.Label();
            this.lb_ThongBao2 = new System.Windows.Forms.Label();
            this.tb_NhapBienSo = new QuanLyBaiXe.VControls.VTextbox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhXeCanSua)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_AnhXeCanSua
            // 
            this.pic_AnhXeCanSua.Location = new System.Drawing.Point(70, 79);
            this.pic_AnhXeCanSua.Name = "pic_AnhXeCanSua";
            this.pic_AnhXeCanSua.Size = new System.Drawing.Size(376, 340);
            this.pic_AnhXeCanSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_AnhXeCanSua.TabIndex = 0;
            this.pic_AnhXeCanSua.TabStop = false;
            // 
            // lb_ThongBao1
            // 
            this.lb_ThongBao1.AutoSize = true;
            this.lb_ThongBao1.Location = new System.Drawing.Point(70, 40);
            this.lb_ThongBao1.Name = "lb_ThongBao1";
            this.lb_ThongBao1.Size = new System.Drawing.Size(120, 16);
            this.lb_ThongBao1.TabIndex = 1;
            this.lb_ThongBao1.Text = "Xe cần sửa biển số";
            // 
            // lb_ThongBao2
            // 
            this.lb_ThongBao2.AutoSize = true;
            this.lb_ThongBao2.Location = new System.Drawing.Point(555, 129);
            this.lb_ThongBao2.Name = "lb_ThongBao2";
            this.lb_ThongBao2.Size = new System.Drawing.Size(104, 16);
            this.lb_ThongBao2.TabIndex = 2;
            this.lb_ThongBao2.Text = "Nhập biển số xe";
            // 
            // tb_NhapBienSo
            // 
            this.tb_NhapBienSo.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NhapBienSo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_NhapBienSo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_NhapBienSo.BorderRadius = 0;
            this.tb_NhapBienSo.BorderSize = 2;
            this.tb_NhapBienSo.ForeColor = System.Drawing.Color.DimGray;
            this.tb_NhapBienSo.Location = new System.Drawing.Point(555, 182);
            this.tb_NhapBienSo.Multiline = false;
            this.tb_NhapBienSo.Name = "tb_NhapBienSo";
            this.tb_NhapBienSo.Padding = new System.Windows.Forms.Padding(7);
            this.tb_NhapBienSo.PasswordChar = false;
            this.tb_NhapBienSo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_NhapBienSo.PlaceholderText = "";
            this.tb_NhapBienSo.Size = new System.Drawing.Size(143, 31);
            this.tb_NhapBienSo.TabIndex = 3;
            this.tb_NhapBienSo.Texts = "";
            this.tb_NhapBienSo.UnderlinedStyle = false;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(555, 262);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(104, 42);
            this.btn_XacNhan.TabIndex = 4;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // vChangeLicensePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.tb_NhapBienSo);
            this.Controls.Add(this.lb_ThongBao2);
            this.Controls.Add(this.lb_ThongBao1);
            this.Controls.Add(this.pic_AnhXeCanSua);
            this.Name = "vChangeLicensePlate";
            this.Text = "vChangeLicensePlate";
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhXeCanSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_AnhXeCanSua;
        private System.Windows.Forms.Label lb_ThongBao1;
        private System.Windows.Forms.Label lb_ThongBao2;
        private VControls.VTextbox tb_NhapBienSo;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}