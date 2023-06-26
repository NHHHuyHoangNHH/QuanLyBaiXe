namespace QuanLyBaiXe
{
    partial class vDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_sothang = new System.Windows.Forms.ComboBox();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_expireddate = new System.Windows.Forms.DateTimePicker();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_bienso = new System.Windows.Forms.TextBox();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.bt_dongtien = new QuanLyBaiXe.VControls.VButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cb_sothang);
            this.panel1.Controls.Add(this.tb_tongtien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_expireddate);
            this.panel1.Controls.Add(this.dt_date);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_bienso);
            this.panel1.Controls.Add(this.tb_tenkh);
            this.panel1.Controls.Add(this.bt_dongtien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 254);
            this.panel1.TabIndex = 2;
            // 
            // cb_sothang
            // 
            this.cb_sothang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sothang.FormattingEnabled = true;
            this.cb_sothang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_sothang.Location = new System.Drawing.Point(136, 138);
            this.cb_sothang.Name = "cb_sothang";
            this.cb_sothang.Size = new System.Drawing.Size(121, 21);
            this.cb_sothang.TabIndex = 14;
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Location = new System.Drawing.Point(340, 141);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.ReadOnly = true;
            this.tb_tongtien.Size = new System.Drawing.Size(140, 20);
            this.tb_tongtien.TabIndex = 15;
            this.tb_tongtien.Text = "150000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng tiền: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số tháng: ";
            // 
            // dt_expireddate
            // 
            this.dt_expireddate.AllowDrop = true;
            this.dt_expireddate.CustomFormat = "dd/MM/yyyy";
            this.dt_expireddate.Enabled = false;
            this.dt_expireddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_expireddate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dt_expireddate.Location = new System.Drawing.Point(136, 178);
            this.dt_expireddate.Name = "dt_expireddate";
            this.dt_expireddate.Size = new System.Drawing.Size(108, 20);
            this.dt_expireddate.TabIndex = 9;
            this.dt_expireddate.Value = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            // 
            // dt_date
            // 
            this.dt_date.CustomFormat = "dd/MM/yyyy";
            this.dt_date.Enabled = false;
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dt_date.Location = new System.Drawing.Point(136, 95);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(108, 20);
            this.dt_date.TabIndex = 3;
            this.dt_date.Value = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(136, 62);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.ReadOnly = true;
            this.tb_sdt.Size = new System.Drawing.Size(164, 20);
            this.tb_sdt.TabIndex = 8;
            // 
            // tb_bienso
            // 
            this.tb_bienso.Location = new System.Drawing.Point(380, 28);
            this.tb_bienso.Name = "tb_bienso";
            this.tb_bienso.ReadOnly = true;
            this.tb_bienso.Size = new System.Drawing.Size(100, 20);
            this.tb_bienso.TabIndex = 7;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(136, 28);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.ReadOnly = true;
            this.tb_tenkh.Size = new System.Drawing.Size(164, 20);
            this.tb_tenkh.TabIndex = 6;
            // 
            // bt_dongtien
            // 
            this.bt_dongtien.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_dongtien.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_dongtien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_dongtien.BorderRadius = 30;
            this.bt_dongtien.BorderSize = 0;
            this.bt_dongtien.FlatAppearance.BorderSize = 0;
            this.bt_dongtien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dongtien.ForeColor = System.Drawing.Color.White;
            this.bt_dongtien.Location = new System.Drawing.Point(173, 218);
            this.bt_dongtien.Margin = new System.Windows.Forms.Padding(2);
            this.bt_dongtien.Name = "bt_dongtien";
            this.bt_dongtien.Size = new System.Drawing.Size(141, 34);
            this.bt_dongtien.TabIndex = 5;
            this.bt_dongtien.Text = "ĐÓNG TIỀN";
            this.bt_dongtien.TextColor = System.Drawing.Color.White;
            this.bt_dongtien.UseVisualStyleBackColor = false;
            this.bt_dongtien.Click += new System.EventHandler(this.bt_dongtien_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày hết hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Biển số xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // vDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 276);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "vDetail";
            this.Text = "vDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_sothang;
        public System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_expireddate;
        private System.Windows.Forms.DateTimePicker dt_date;
        public System.Windows.Forms.TextBox tb_sdt;
        public System.Windows.Forms.TextBox tb_bienso;
        public System.Windows.Forms.TextBox tb_tenkh;
        private VControls.VButton bt_dongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}