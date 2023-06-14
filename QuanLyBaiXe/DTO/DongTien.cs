using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DTO
{
    public class DongTien
    {
        public DongTien(string bienso, DateTime? ngaydong, int sothang)
        {
            this.BienSo = bienso;
            this.NgayDong = ngaydong;
            this.SoThang = sothang;
        }

        public DongTien(DataRow row)
        {
            this.BienSo = row["BienSo"].ToString(); ;
            this.NgayDong = (DateTime?)row["NgayDong"];
            this.SoThang = (int) row["SoThang"];
        }

        private string bienso;

        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }

        private DateTime? ngaydong;

        public DateTime? NgayDong
        {
            get { return ngaydong; }
            set { ngaydong = value; }
        }

        private int sothang;

        public int SoThang
        {
            get { return sothang; }
            set { sothang = value; }
        }
    }
}
