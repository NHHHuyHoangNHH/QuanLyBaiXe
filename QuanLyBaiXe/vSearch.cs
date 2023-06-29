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
    public partial class vSearch : Form
    {
        BindingSource XELIST = new BindingSource();
        public vSearch()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            Loading();
            CloseForm();
        }

        #region Method
        void Loading()
        {
            data_Search.DataSource = XELIST;

            LoadXe();
            LoadXeBinding();
        }

        void CloseForm()
        {
            this.FormClosing += new FormClosingEventHandler(vSearch_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vSearch_FormClosed);
        }

        void LoadXe()
        {
            XELIST.DataSource = XeDAO.Instance.LoadXeTable();
            DataProvider.Instance.AutoFitColumns(data_Search);
        }

        void LoadXeBinding()
        {
            tb_biensoxe_Search.DataBindings.Add(new Binding("Texts", data_Search.DataSource, "BienSo", true, DataSourceUpdateMode.Never));
        }

        void SearchXe(string bienso)
        {
            XELIST.DataSource = XeDAO.Instance.SearchXe(bienso);
            DataProvider.Instance.AutoFitColumns(data_Search);
        }
        #endregion

        #region Events
        private void bt_InOut_Click(object sender, EventArgs e)
        {
            vInOut v = new vInOut();
            this.Hide();
            v.ShowDialog(); ;
        }

        private void bt_VIP_Click(object sender, EventArgs e)
        {
            vVIP v = new vVIP();
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

        private void bt_Money_Click(object sender, EventArgs e)
        {
            vThamSo v = new vThamSo();
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

        private void vSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        private void vSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggDAO.Instance.LogDangXuat();
            Environment.Exit(0);
        }

        private void bt_tim_Search_Click(object sender, EventArgs e)
        {
            SearchXe(tb_biensoxe_Search.Texts);
        }

        private void bt_Reload_Search_Click(object sender, EventArgs e)
        {
            LoadXe();
        }

        #endregion


    }
}
