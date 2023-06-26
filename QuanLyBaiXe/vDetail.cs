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
    public partial class vDetail : Form
    {
        public vDetail()
        {
            InitializeComponent();

            Loading();
        }

        #region Method
        void Loading()
        {
            GetBasicValue();
            GetTongTienValue();
            GetExpiredDate();
        }

        void GetBasicValue()
        {
            tb_tenkh.Text = ((vVIP)Application.OpenForms["vVIP"]).tb_tenkh_VIP.Texts;
            tb_sdt.Text = ((vVIP)Application.OpenForms["vVIP"]).tb_sdt_VIP.Texts;
            tb_bienso.Text = ((vVIP)Application.OpenForms["vVIP"]).tb_biensoxe_VIP.Texts;
            dt_date.Value = DateTime.Now;
            dt_expireddate.Value = ((vVIP)Application.OpenForms["vVIP"]).GetNgayHetHan().AddDays(30);
        }

        void GetTongTienValue()
        {
            cb_sothang.SelectedIndex = 0;
            cb_sothang.SelectedIndexChanged += (sender, e) =>
            {
                if (cb_sothang.SelectedItem != null)
                {
                    int selectedValue = int.Parse(cb_sothang.SelectedItem.ToString());

                    int calculatedValue = selectedValue * 150000;

                    tb_tongtien.Text = calculatedValue.ToString();
                }
            };
        }

        void GetExpiredDate()
        {
            cb_sothang.SelectedIndexChanged += (sender, e) => {
                if (cb_sothang.SelectedItem != null)
                {
                    int selectedValue = int.Parse(cb_sothang.SelectedItem.ToString());
                    DateTime currentValue = ((vVIP)Application.OpenForms["vVIP"]).GetNgayHetHan();
                    DateTime newValue = currentValue.AddDays(30 * selectedValue);
                    dt_expireddate.Value = newValue;
                }
            };
        }
        #endregion

        #region Event
        private void bt_dongtien_Click(object sender, EventArgs e)
        {
            string bienso = tb_bienso.Text;
            string sothang = cb_sothang.Text;
            int tienvip = (int)DataProvider.Instance.ExecuteScalar("select tienvip from ThamSo");
            DateTime date = dt_date.Value;
            DateTime exdate = ((vVIP)Application.OpenForms["vVIP"]).GetNgayHetHan();


            if (DongTienDAO.Instance.AddDONGTIEN(bienso, int.Parse(sothang)))
            {
                DoanhThuDAO.Instance.UpdateDoanhThu(tienvip);
                MessageBox.Show("Đóng tiền thành công!");
                LoggDAO.Instance.LogDongTien(bienso, int.Parse(sothang), 0);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đóng tiền không thành công!");
                LoggDAO.Instance.LogDongTien(bienso, int.Parse(sothang), 0);
            }
        }
        #endregion


    }
}
