using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DTO
{
    public class DoanhThu
    {
        public DoanhThu(int nam, int thang, int sotien)
        {
            this.Nam = nam;
            this.Thang = thang;
            this.SoTien = sotien;
        }

        public DoanhThu(DataRow row)
        {
            this.Nam = (int)row["Nam"];
            this.Thang = (int)row["Thang"];
            this.SoTien = (int)row["SoTien"];
        }

        private int nam;

        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        private int thang;

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        private int sotien;

        public int SoTien
        {
            get { return sotien; }
            set { sotien = value; }
        }
    }
}
