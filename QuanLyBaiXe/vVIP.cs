using QuanLyBaiXe.DAO;
using QuanLyBaiXe.DTO;
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
    public partial class vVIP : Form
    {
        BindingSource VIPLIST = new BindingSource();
        public vVIP()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            Loading();
            CloseForm();
        }

        #region Method
        void CloseForm()
        {
            this.FormClosing += new FormClosingEventHandler(vVIP_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vVIP_FormClosed);
        }
        void Loading()
        {
            data_VIP.DataSource = VIPLIST;

            LoadVIP();
            LoadVIPBinding();
        }

        void LoadVIP()
        {
            VIPLIST.DataSource = VIPDAO.Instance.LoadVIPtable();
            DataProvider.Instance.AutoFitColumns(data_VIP);
        }

        void LoadVIPBinding()
        {
            tb_biensoxe_VIP.DataBindings.Add(new Binding("Texts", data_VIP.DataSource, "BienSo", true, DataSourceUpdateMode.Never));
            tb_sdt_VIP.DataBindings.Add(new Binding("Texts", data_VIP.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            tb_tenkh_VIP.DataBindings.Add(new Binding("Texts", data_VIP.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            dt_ngaylamve_VIP.DataBindings.Add(new Binding("Value", data_VIP.DataSource, "NgayDK", true, DataSourceUpdateMode.Never));
            dt_ngayhethan_VIP.DataBindings.Add(new Binding("Value", data_VIP.DataSource, "NgayHH", true, DataSourceUpdateMode.Never));
        }

        public DateTime GetNgayHetHan()
        {
            return dt_ngayhethan_VIP.Value;
        }

        List<VIP> SearchVIP(string bienso)
        {
            List<VIP> listVIP = VIPDAO.Instance.SearchVIP(bienso);

            return listVIP;
        }
        #endregion

        #region Event
        //Nut chuyen trang
        private void bt_InOut_Click(object sender, EventArgs e)
        {
            vInOut v = new vInOut();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            vSearch v = new vSearch();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_Revenue_Click(object sender, EventArgs e)
        {
            vRevenue v = new vRevenue();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_Money_Click(object sender, EventArgs e)
        {
            vThamSo v = new vThamSo();
            v.ShowDialog();
        }

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            v.ShowDialog();
        }
        private void bt_dongtien_VIP_Click(object sender, EventArgs e)
        {
            vDetail v = new vDetail();
            v.ShowDialog();
        }

        //Nut chuc nang them + xoa + sua + tim kiem
        private void bt_them_VIP_Click(object sender, EventArgs e)
        {
            string hoten = tb_tenkh_VIP.Texts;
            string bienso = tb_biensoxe_VIP.Texts;
            string sdt = tb_sdt_VIP.Texts;

            if (VIPDAO.Instance.AddVIP(bienso, hoten, sdt))
            {
                DoanhThuDAO.Instance.UpdateDoanhThu((int)DataProvider.Instance.ExecuteScalar("select tiencocVIP from ThamSo"));
                MessageBox.Show("Thêm VIP thành công");
                LoggDAO.Instance.LogVIP(bienso, 0, 0);
                LoadVIP();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm VIP");
                LoggDAO.Instance.LogVIP(bienso, 0, 1);
            }
        }

        private void bt_xoa_VIP_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxe_VIP.Texts;
            DongTienDAO.Instance.DeteleDONGTIEN(bienso);
            if (VIPDAO.Instance.DeteleVIP(bienso))
            {
                DoanhThuDAO.Instance.DeleteDoanhThu((int)DataProvider.Instance.ExecuteScalar("select tiencocVIP from ThamSo"));
                MessageBox.Show("Xóa xe thành công");
                LoggDAO.Instance.LogVIP(bienso, 1, 0);
                LoadVIP();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa xe");
                LoggDAO.Instance.LogVIP(bienso, 1, 1);

            }
        }

        private void bt_sua_VIP_Click(object sender, EventArgs e)
        {
            string hoten = tb_tenkh_VIP.Texts;
            string bienso = tb_biensoxe_VIP.Texts;
            string sdt = tb_sdt_VIP.Texts;

            if (VIPDAO.Instance.UpdateVIP(bienso, hoten, sdt))
            {
                MessageBox.Show("Sửa VIP thành công");
                LoggDAO.Instance.LogVIP(bienso, 1, 1);
                LoadVIP();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa VIP");
                LoggDAO.Instance.LogVIP(bienso, 1, 1);
            }
        }

        private void bt_tim_VIP_Click(object sender, EventArgs e)
        {
            VIPLIST.DataSource = SearchVIP(tb_biensoxe_VIP.Texts);
            string query = string.Format("exec PDInsertLOGG 'Tìm xe có biển số là {0} '", tb_biensoxe_VIP.Texts);
            DataProvider.Instance.ExecuteQuery(query);
        }

        private void bt_luu_VIP_Click(object sender, EventArgs e)
        {
            LoadVIP();
        }

        //Dang xuat + Thoat
        private void vVIP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoggDAO.Instance.LogDangXuat();
                Environment.Exit(0);
            }
        }

        private void vVIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LoggDAO.Instance.LogDangXuat();
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

    }
}
