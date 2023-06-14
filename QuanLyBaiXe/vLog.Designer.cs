namespace QuanLyBaiXe
{
    partial class vLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_ngaycantrichxuat = new QuanLyBaiXe.VControls.VDateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_LogOut = new QuanLyBaiXe.VControls.VButton();
            this.bt_Log = new QuanLyBaiXe.VControls.VButton();
            this.bt_Revenue = new QuanLyBaiXe.VControls.VButton();
            this.bt_Search = new QuanLyBaiXe.VControls.VButton();
            this.bt_VIP = new QuanLyBaiXe.VControls.VButton();
            this.bt_InOut = new QuanLyBaiXe.VControls.VButton();
            this.data_Log = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bt_tim_Log = new QuanLyBaiXe.VControls.VButton();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Log)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_ngaycantrichxuat);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.data_Log);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 13;
            // 
            // dt_ngaycantrichxuat
            // 
            this.dt_ngaycantrichxuat.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dt_ngaycantrichxuat.BorderSize = 2;
            this.dt_ngaycantrichxuat.CustomFormat = "dd MMMM, yyy";
            this.dt_ngaycantrichxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dt_ngaycantrichxuat.Location = new System.Drawing.Point(403, 5);
            this.dt_ngaycantrichxuat.MinimumSize = new System.Drawing.Size(4, 30);
            this.dt_ngaycantrichxuat.Name = "dt_ngaycantrichxuat";
            this.dt_ngaycantrichxuat.Size = new System.Drawing.Size(253, 30);
            this.dt_ngaycantrichxuat.SkinColor = System.Drawing.Color.White;
            this.dt_ngaycantrichxuat.TabIndex = 12;
            this.dt_ngaycantrichxuat.TextColor = System.Drawing.Color.DimGray;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bt_LogOut);
            this.panel3.Controls.Add(this.bt_Log);
            this.panel3.Controls.Add(this.bt_Revenue);
            this.panel3.Controls.Add(this.bt_Search);
            this.panel3.Controls.Add(this.bt_VIP);
            this.panel3.Controls.Add(this.bt_InOut);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 426);
            this.panel3.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bt_LogOut
            // 
            this.bt_LogOut.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_LogOut.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_LogOut.BorderColor = System.Drawing.Color.Black;
            this.bt_LogOut.BorderRadius = 0;
            this.bt_LogOut.BorderSize = 1;
            this.bt_LogOut.FlatAppearance.BorderSize = 0;
            this.bt_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogOut.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LogOut.ForeColor = System.Drawing.Color.White;
            this.bt_LogOut.Location = new System.Drawing.Point(0, 372);
            this.bt_LogOut.Name = "bt_LogOut";
            this.bt_LogOut.Size = new System.Drawing.Size(172, 54);
            this.bt_LogOut.TabIndex = 11;
            this.bt_LogOut.Text = "Đăng Xuất";
            this.bt_LogOut.TextColor = System.Drawing.Color.White;
            this.bt_LogOut.UseVisualStyleBackColor = false;
            this.bt_LogOut.Click += new System.EventHandler(this.bt_LogOut_Click);
            // 
            // bt_Log
            // 
            this.bt_Log.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Log.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_Log.BorderColor = System.Drawing.Color.Black;
            this.bt_Log.BorderRadius = 0;
            this.bt_Log.BorderSize = 1;
            this.bt_Log.FlatAppearance.BorderSize = 0;
            this.bt_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Log.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Log.ForeColor = System.Drawing.Color.White;
            this.bt_Log.Location = new System.Drawing.Point(0, 318);
            this.bt_Log.Name = "bt_Log";
            this.bt_Log.Size = new System.Drawing.Size(172, 54);
            this.bt_Log.TabIndex = 10;
            this.bt_Log.Text = "Log";
            this.bt_Log.TextColor = System.Drawing.Color.White;
            this.bt_Log.UseVisualStyleBackColor = false;
            // 
            // bt_Revenue
            // 
            this.bt_Revenue.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Revenue.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_Revenue.BorderColor = System.Drawing.Color.Black;
            this.bt_Revenue.BorderRadius = 0;
            this.bt_Revenue.BorderSize = 1;
            this.bt_Revenue.FlatAppearance.BorderSize = 0;
            this.bt_Revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Revenue.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Revenue.ForeColor = System.Drawing.Color.White;
            this.bt_Revenue.Location = new System.Drawing.Point(0, 264);
            this.bt_Revenue.Name = "bt_Revenue";
            this.bt_Revenue.Size = new System.Drawing.Size(172, 54);
            this.bt_Revenue.TabIndex = 9;
            this.bt_Revenue.Text = "Doanh Thu";
            this.bt_Revenue.TextColor = System.Drawing.Color.White;
            this.bt_Revenue.UseVisualStyleBackColor = false;
            this.bt_Revenue.Click += new System.EventHandler(this.bt_Revenue_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Search.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_Search.BorderColor = System.Drawing.Color.Black;
            this.bt_Search.BorderRadius = 0;
            this.bt_Search.BorderSize = 1;
            this.bt_Search.FlatAppearance.BorderSize = 0;
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.Location = new System.Drawing.Point(0, 210);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(172, 54);
            this.bt_Search.TabIndex = 8;
            this.bt_Search.Text = "Tìm Kiếm";
            this.bt_Search.TextColor = System.Drawing.Color.White;
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_VIP
            // 
            this.bt_VIP.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_VIP.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_VIP.BorderColor = System.Drawing.Color.Black;
            this.bt_VIP.BorderRadius = 0;
            this.bt_VIP.BorderSize = 1;
            this.bt_VIP.FlatAppearance.BorderSize = 0;
            this.bt_VIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_VIP.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_VIP.ForeColor = System.Drawing.Color.White;
            this.bt_VIP.Location = new System.Drawing.Point(0, 156);
            this.bt_VIP.Name = "bt_VIP";
            this.bt_VIP.Size = new System.Drawing.Size(172, 54);
            this.bt_VIP.TabIndex = 7;
            this.bt_VIP.Text = "Vé VIP";
            this.bt_VIP.TextColor = System.Drawing.Color.White;
            this.bt_VIP.UseVisualStyleBackColor = false;
            this.bt_VIP.Click += new System.EventHandler(this.bt_VIP_Click);
            // 
            // bt_InOut
            // 
            this.bt_InOut.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_InOut.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_InOut.BorderColor = System.Drawing.Color.Black;
            this.bt_InOut.BorderRadius = 0;
            this.bt_InOut.BorderSize = 1;
            this.bt_InOut.FlatAppearance.BorderSize = 0;
            this.bt_InOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_InOut.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_InOut.ForeColor = System.Drawing.Color.White;
            this.bt_InOut.Location = new System.Drawing.Point(0, 102);
            this.bt_InOut.Name = "bt_InOut";
            this.bt_InOut.Size = new System.Drawing.Size(172, 54);
            this.bt_InOut.TabIndex = 6;
            this.bt_InOut.Text = "Xe Ra Vào";
            this.bt_InOut.TextColor = System.Drawing.Color.White;
            this.bt_InOut.UseVisualStyleBackColor = false;
            this.bt_InOut.Click += new System.EventHandler(this.bt_InOut_Click);
            // 
            // data_Log
            // 
            this.data_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Log.Location = new System.Drawing.Point(175, 102);
            this.data_Log.Name = "data_Log";
            this.data_Log.RowHeadersWidth = 51;
            this.data_Log.RowTemplate.Height = 24;
            this.data_Log.Size = new System.Drawing.Size(598, 324);
            this.data_Log.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày cần trích xuất:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bt_tim_Log);
            this.panel7.Location = new System.Drawing.Point(175, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(598, 42);
            this.panel7.TabIndex = 4;
            // 
            // bt_tim_Log
            // 
            this.bt_tim_Log.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_tim_Log.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.bt_tim_Log.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_tim_Log.BorderRadius = 30;
            this.bt_tim_Log.BorderSize = 0;
            this.bt_tim_Log.FlatAppearance.BorderSize = 0;
            this.bt_tim_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tim_Log.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim_Log.ForeColor = System.Drawing.Color.White;
            this.bt_tim_Log.Location = new System.Drawing.Point(247, 1);
            this.bt_tim_Log.Name = "bt_tim_Log";
            this.bt_tim_Log.Size = new System.Drawing.Size(104, 40);
            this.bt_tim_Log.TabIndex = 6;
            this.bt_tim_Log.Text = "TÌM";
            this.bt_tim_Log.TextColor = System.Drawing.Color.White;
            this.bt_tim_Log.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "Đăng xuất";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 426);
            this.panel2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vé VIP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Log";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xe ra vào";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Doanh thu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // vLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "vLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vLog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Log)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private VControls.VButton bt_LogOut;
        private VControls.VButton bt_Log;
        private VControls.VButton bt_Revenue;
        private VControls.VButton bt_Search;
        private VControls.VButton bt_VIP;
        private VControls.VButton bt_InOut;
        private VControls.VDateTimePicker dt_ngaycantrichxuat;
        private VControls.VButton bt_tim_Log;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}