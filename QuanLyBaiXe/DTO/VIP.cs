using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DTO
{
    public class VIP
    {
        public VIP(string bienso, string hoten, string sdt, DateTime ngaydk)
        {
            this.BienSo = bienso;
            this.Hoten = hoten;
            this.SDT = sdt;
            this.NgayDK = ngaydk;
        }

        public VIP(DataRow row)
        {
            this.BienSo = row["BIENSO"].ToString();
            this.Hoten = row["HOTEN"].ToString();
            this.SDT = row["SDT"].ToString();
<<<<<<< HEAD
            this.NgayDK = (DateTime)row["NGAYVAO"];
=======
            this.NgayDK = (DateTime?)row["NGAYDK"];
>>>>>>> b6311ec60561f2d3e3052c7c6e77029964c9760a
        }

        private string bienso;

        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }

        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        private string sdt;

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private DateTime ngaydk;

        public DateTime NgayDK
        {
            get { return ngaydk; }
            set { ngaydk = value; }
        }
    }
}
