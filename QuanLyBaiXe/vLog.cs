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
    public partial class vLog : Form
    {
        public vLog()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            Loading();
            ClosedForm();
        }

        #region Method
        void Loading()
        {
            LoadLogg();
        }
        void LoadLogg()
        {
            data_Logg.DataSource = LoggDAO.Instance.LoadLogTable();
            DataProvider.Instance.AutoFitColumns(data_Logg);
        }
        void ClosedForm()
        {
            this.FormClosing += new FormClosingEventHandler(vLog_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vLog_FormClosed);
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

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoggDAO.Instance.LogDangXuat();
                Environment.Exit(0);
            }
        }

        private void vLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LoggDAO.Instance.LogDangXuat();
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void vLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        private void bt_tim_Log_Click(object sender, EventArgs e)
        {

        }

        private void bt_Money_Click(object sender, EventArgs e)
        {
            vThamSo v = new vThamSo();
            v.ShowDialog();
        }
    }
}
