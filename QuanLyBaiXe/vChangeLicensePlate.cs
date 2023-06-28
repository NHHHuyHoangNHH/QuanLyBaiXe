using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiXe
{
    public partial class vChangeLicensePlate : Form
    {
        private string imgPathFormIO;
        public event Action<string> LicensePlateChanged;

        public vChangeLicensePlate(string imgPath)
        {
            InitializeComponent();
            imgPathFormIO = imgPath;
            pic_AnhXeCanSua.Image = new Bitmap(imgPathFormIO);
            btn_XacNhan.Text = "Xác nhận";
            lb_ThongBao1.Text = "Ảnh xe";
            lb_ThongBao2.Text = "Nhập biển số xe";
        }

        public string getNewLicensePlate()
        {
            return tb_NhapBienSo.Texts;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn về biển số xe mới chưa", "Thông báo", MessageBoxButtons.OKCancel);

            // Kiểm tra kết quả từ cửa sổ thông báo
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
