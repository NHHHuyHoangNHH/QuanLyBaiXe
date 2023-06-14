namespace QuanLyBaiXe
{
    partial class vLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_dangnhap = new QuanLyBaiXe.VControls.VButton();
            this.tb_matkhau = new QuanLyBaiXe.VControls.VTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bt_dangnhap);
            this.panel2.Controls.Add(this.tb_matkhau);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 267);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_dangnhap.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_dangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_dangnhap.BorderRadius = 50;
            this.bt_dangnhap.BorderSize = 0;
            this.bt_dangnhap.FlatAppearance.BorderSize = 0;
            this.bt_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangnhap.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.ForeColor = System.Drawing.Color.White;
            this.bt_dangnhap.Location = new System.Drawing.Point(284, 175);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(187, 55);
            this.bt_dangnhap.TabIndex = 2;
            this.bt_dangnhap.Text = "ĐĂNG NHẬP";
            this.bt_dangnhap.TextColor = System.Drawing.Color.White;
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.SystemColors.Window;
            this.tb_matkhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_matkhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_matkhau.BorderRadius = 15;
            this.tb_matkhau.BorderSize = 2;
            this.tb_matkhau.ForeColor = System.Drawing.Color.DimGray;
            this.tb_matkhau.Location = new System.Drawing.Point(218, 136);
            this.tb_matkhau.Multiline = false;
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Padding = new System.Windows.Forms.Padding(7);
            this.tb_matkhau.PasswordChar = true;
            this.tb_matkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_matkhau.PlaceholderText = "";
            this.tb_matkhau.Size = new System.Drawing.Size(323, 31);
            this.tb_matkhau.TabIndex = 1;
            this.tb_matkhau.Texts = "";
            this.tb_matkhau.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // vLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "vLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vLogin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private VControls.VButton bt_dangnhap;
        private VControls.VTextbox tb_matkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}