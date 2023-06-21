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
            LoadRevenue();

            this.FormClosing += new FormClosingEventHandler(vRevenue_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vRevenue_FormClosed);
        }

        #region Method
        void LoadRevenue()
        {
            lsvRevenue.Items.Clear();
            List < DoanhThu > DTList = DoanhThuDAO.Instance.LoadDoanhThu();

            foreach ( DoanhThu item in DTList )
            {
                ListViewItem listItem = new ListViewItem(item.Nam.ToString());
                listItem.SubItems.Add(item.Thang.ToString());
                listItem.SubItems.Add(item.SoTien.ToString());

                lsvRevenue.Items.Add(listItem);
            }    
        }
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

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void vRevenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_tim_Revenue_Click(object sender, EventArgs e)
        {
            int nam = dt_nam_Revenue.Value.Year;
            int month = dt_nam_Revenue.Value.Month;

            lsvRevenue.Items.Clear();
            List<DoanhThu> DTList = DoanhThuDAO.Instance.LoadDoanhThu();

            foreach (DoanhThu item in DTList)
            {
                ListViewItem listItem = new ListViewItem(item.Nam.ToString());
                listItem.SubItems.Add(item.Thang.ToString());
                listItem.SubItems.Add(item.SoTien.ToString());

                lsvRevenue.Items.Add(listItem);
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void vRevenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        private void vRevenue_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= currentYear - 100; year--)
            {
                cb_year.Items.Add(year);
            }
            cb_year.SelectedItem = currentYear;

            string[] months = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            cb_month.Items.AddRange(months);
            cb_month.SelectedIndex = 0;
        }
    }
}
