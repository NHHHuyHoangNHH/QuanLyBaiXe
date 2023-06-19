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
        public vVIP()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            Loading();


            this.FormClosing += new FormClosingEventHandler(vVIP_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vVIP_FormClosed);
        }

        #region Method
        void Loading()
        {
            LoadVIP();
            LoadVIPBinding();
        }
    
        void LoadVIP()
        {
            data_VIP.DataSource = VIPDAO.Instance.LoadVIPtable();
        }

        void LoadVIPBinding()
        {
            tb_biensoxe_VIP.DataBindings.Add(new Binding("Texts", data_VIP.DataSource, "BienSo"));
            tb_sdt_VIP.DataBindings.Add(new Binding("Texts", data_VIP.DataSource, "SDT"));
            tb_tenkh_VIP.DataBindings.Add(new Binding("Texts", data_VIP.DataSource, "HoTen"));
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

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            v.ShowDialog();
        }

        //Nut chuc nang them + xoa + sua + luu
        private void bt_them_VIP_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_xoa_VIP_Click(object sender, EventArgs e)
        {

        }

        private void bt_tim_VIP_Click(object sender, EventArgs e)
        {

        }

        private void bt_sua_VIP_Click(object sender, EventArgs e)
        {

        }

        private void bt_luu_VIP_Click(object sender, EventArgs e)
        {

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
                Environment.Exit(0);
            }
        }

        private void vVIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
