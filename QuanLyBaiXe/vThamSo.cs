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
    public partial class vThamSo : Form
    {
        public vThamSo()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;

            Loading();
            ClosedForm();
        }

        #region Method
        void Loading()
        {
            LoadThamSo();
        }
        void ClosedForm()
        {
            this.FormClosing += new FormClosingEventHandler(vThamSo_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vThamSo_FormClosed);
        }
            
        void LoadThamSo()
        {
            tb_moctien1.Texts = ThamSoDAO.Instance.GetThamSo().MocTien1.ToString();
            tb_moctien2.Texts = ThamSoDAO.Instance.GetThamSo().MocTien2.ToString();
            tb_tiencocVIP.Texts = ThamSoDAO.Instance.GetThamSo().TienCocVip.ToString();
            tb_tienVIP.Texts = ThamSoDAO.Instance.GetThamSo().TienVip.ToString();
            cb_mocthoigian1.Texts = ThamSoDAO.Instance.GetThamSo().MocThoiGian1.ToString();
            cb_mocthoigian2.Texts = ThamSoDAO.Instance.GetThamSo().MocThoiGian2.ToString();
            cb_mocthoigian3.Texts = ThamSoDAO.Instance.GetThamSo().MocThoiGian3.ToString();
        }
        #endregion

        #region Event
        private void bt_InOut_Click(object sender, EventArgs e)
        {
            vInOut v = new vInOut();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_VIP_Click(object sender, EventArgs e)
        {
            vVIP v = new vVIP();
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

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            v.ShowDialog();
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

        private void vThamSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            LoggDAO.Instance.LogDangXuat();
        }

        private void vThamSo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_datlai_Click(object sender, EventArgs e)
        {
            LoadThamSo();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            ThamSo add = new ThamSo(0,0,0,0,0,0,0);
            add.MocTien1 = int.Parse(tb_moctien1.Texts);
            add.MocTien2 = int.Parse(tb_moctien2.Texts);
            add.TienVip = int.Parse(tb_tienVIP.Texts);
            add.TienCocVip = int.Parse(tb_tiencocVIP.Texts);
            add.MocThoiGian1 = int.Parse(cb_mocthoigian1.Texts);
            add.MocThoiGian2 = int.Parse(cb_mocthoigian2.Texts);
            add.MocThoiGian3 = int.Parse(cb_mocthoigian3.Texts);
            DialogResult result = MessageBox.Show("Bạn muốn thay đổi các giá trị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ThamSoDAO.Instance.UpdateThamSo(add) != 0)
                {
                    MessageBox.Show("Update thành công!");
                }
            }
   
        }
        #endregion
    }
}