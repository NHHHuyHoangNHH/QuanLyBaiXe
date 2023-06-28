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
            Loading();
            ClosedForm();
        }

        #region Method
        void Loading()
        {
            GetCurrentDate();
        }

        void ClosedForm()
        {
            this.FormClosing += new FormClosingEventHandler(vInOut_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vInOut_FormClosed);
        }
        public void GetCurrentDate()
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dt_date.Texts = dateTimePicker1.Value.ToString(dateTimePicker1.CustomFormat);
        }
        #endregion

        #region Event
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
            GetCurrentDate();

            string bienso = tb_biensoxevao.Texts;

            while (string.IsNullOrEmpty(bienso))
            {
                Application.DoEvents();///////////////them event vo 
                bienso = tb_biensoxevao.Text;
            }
            LoggDAO.Instance.LogInOut(bienso, 0);
            XeDAO.Instance.AddXe(bienso);
        }

        private void bt_xera_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxera.Texts;
            LoggDAO.Instance.LogInOut(bienso, 1);
        }



        #endregion
    }
}
