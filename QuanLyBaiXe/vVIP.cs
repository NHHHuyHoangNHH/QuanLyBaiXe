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
            LoadVIP();
        }

        #region Method
        void LoadVIP()
        {
            data_VIP.DataSource = VIPDAO.Instance.LoadVIPtable();
        }
        #endregion

        #region Event
        private void bt_InOut_Click(object sender, EventArgs e)
        {
            vInOut v = new vInOut();
            this.Hide();
            this.Close();
            v.ShowDialog();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            vSearch v = new vSearch();
            this.Hide();
            this.Close();
            v.ShowDialog();
        }

        private void bt_Revenue_Click(object sender, EventArgs e)
        {
            vRevenue v = new vRevenue();
            this.Hide();
            this.Close();
            v.ShowDialog();
        }

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            this.Close();
            v.ShowDialog();
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vVIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

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
        #endregion
    }
}
