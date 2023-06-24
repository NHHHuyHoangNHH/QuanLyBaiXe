namespace QuanLyBaiXe
{
    partial class vLoading
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
            this.pic_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Loading
            // 
            this.pic_Loading.Image = global::QuanLyBaiXe.Properties.Resources.loading;
            this.pic_Loading.Location = new System.Drawing.Point(271, 124);
            this.pic_Loading.Name = "pic_Loading";
            this.pic_Loading.Size = new System.Drawing.Size(256, 202);
            this.pic_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Loading.TabIndex = 0;
            this.pic_Loading.TabStop = false;
            // 
            // vLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_Loading);
            this.Name = "vLoading";
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Loading;
    }
}