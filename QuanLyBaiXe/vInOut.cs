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
    public partial class vInOut : Form
    {
        public vInOut()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;

            this.FormClosing += new FormClosingEventHandler(vInOut_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vInOut_FormClosed);
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

        private void vInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LoggDAO.Instance.LogDangXuat();
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void vInOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_xevao_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxevao.Texts;
            LoggDAO.Instance.LogInOut(bienso, 0);
        }

        private void bt_xera_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxera.Texts;
            LoggDAO.Instance.LogInOut(bienso, 1);
        }
    }
}
