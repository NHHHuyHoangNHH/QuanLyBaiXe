using QuanLyBaiXe.DAO;
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
    public partial class vLogin : Form
    {
        public vLogin()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if(tb_matkhau.Texts == "u")
            {
                LoggDAO.Instance.LogDangNhap();
                vInOut v = new vInOut();
                this.Hide();
                v.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mật khẩu sai!");
            }
        }
    }
}
