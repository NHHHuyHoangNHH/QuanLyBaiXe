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
        public vSearch()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            LoadXe();

            this.FormClosing += new FormClosingEventHandler(vSearch_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vSearch_FormClosed);
        }

        #region Method
        void LoadXe()
        {
            lsvSearch.Items.Clear();
            List<Xe> XeList = XeDAO.Instance.LoadXeList();

            foreach (Xe item in XeList)
            {
                ListViewItem listItem = new ListViewItem(item.BienSo);
                listItem.SubItems.Add(item.NgayVao.ToString("dd/MM/yyyy"));

                lsvSearch.Items.Add(listItem);
            }
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

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
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
            Environment.Exit(0);
        }

        private void bt_tim_Search_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxe_Search.Texts;

            List<Xe> XeList = XeDAO.Instance.FindXe(bienso);

            if (XeList.Count == 0) 
            {
                DialogResult result = MessageBox.Show("Không tìm thấy xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            lsvSearch.Items.Clear();
            foreach (Xe item in XeList)
            {
                ListViewItem listItem = new ListViewItem(item.BienSo);
                listItem.SubItems.Add(item.NgayVao.ToString("dd/MM/yyyy"));
                item.NgayVao.ToString();

                lsvSearch.Items.Add(listItem);
            }
        }
        #endregion
    }
}
