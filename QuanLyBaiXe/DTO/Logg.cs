using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DTO
{
    public class Logg
    {
        public Logg(DateTime? thoigian, string thongtin)
        {
            this.ThoiGian = thoigian;
            this.ThongTin = thongtin;
        }

        public Logg(DataRow row)
        {
            this.ThoiGian = (DateTime?) row["ThoiGian"];
            this.ThongTin = row["ThongTin"].ToString();
        }

        private DateTime? thoigian;

        public DateTime? ThoiGian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private string thongtin;

        public string ThongTin
        {
            get { return thongtin; }
            set { thongtin = value; }
        }
    }
}
