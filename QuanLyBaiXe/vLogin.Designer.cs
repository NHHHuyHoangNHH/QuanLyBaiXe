﻿namespace QuanLyBaiXe
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
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 346);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bt_dangnhap);
            this.panel2.Controls.Add(this.tb_matkhau);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 217);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 76);
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
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.ForeColor = System.Drawing.Color.White;
            this.bt_dangnhap.Location = new System.Drawing.Point(213, 142);
            this.bt_dangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(140, 45);
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
            this.tb_matkhau.Location = new System.Drawing.Point(164, 110);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_matkhau.Multiline = false;
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_matkhau.PasswordChar = true;
            this.tb_matkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_matkhau.PlaceholderText = "";
            this.tb_matkhau.Size = new System.Drawing.Size(242, 26);
            this.tb_matkhau.TabIndex = 1;
            this.tb_matkhau.Texts = "";
            this.tb_matkhau.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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