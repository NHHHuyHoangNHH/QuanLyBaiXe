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
    public partial class vRevenue : Form
    {
        public vRevenue()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            Loading();
            CLosedForm();
        }

        #region Method
        void Loading()
        {
            LoadRevenue();
        }
        void CLosedForm()
        {
            this.FormClosing += new FormClosingEventHandler(vRevenue_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vRevenue_FormClosed);
        }
        void LoadRevenue()
        {
            data_Revenue.DataSource = DoanhThuDAO.Instance.LoadRevenueTable();
            DataProvider.Instance.AutoFitColumns(data_Revenue);
        }

        //        List<vRevenue> SearchVenenue(string )
        #endregion

        #region Events
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

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            v.ShowDialog(); ;
        }

        private void bt_Money_Click(object sender, EventArgs e)
        {
            vThamSo v = new vThamSo();
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

        private void vRevenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LoggDAO.Instance.LogDangXuat();
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_tim_Revenue_Click(object sender, EventArgs e)
        {
            data_Revenue.DataSource = DoanhThuDAO.Instance.SearchRevenue(int.Parse(cb_year.Texts), cb_month.Texts);
        }

        private void vRevenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void vRevenue_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= currentYear - 100; year--)
            {
                cb_year.Items.Add(year);
            }
            cb_year.SelectedItem = currentYear;

            string[] months = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"/* "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"*/ };
            cb_month.Items.AddRange(months);
            cb_month.SelectedIndex = 0;
        }

        private void bt_Reload_Revenue_Click(object sender, EventArgs e)
        {
            LoadRevenue();
        }
        #endregion

    }
}
