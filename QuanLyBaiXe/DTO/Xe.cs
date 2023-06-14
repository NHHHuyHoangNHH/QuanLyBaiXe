using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DTO
{
    public class Xe
    {
        public Xe(string bienso, DateTime? ngayvao)
        {
            this.BienSo = bienso;
            this.NgayVao = ngayvao;
        }

        public Xe(DataRow row)
        {
            this.BienSo = row["BIENSO"].ToString();
            this.NgayVao = (DateTime?) row["NGAYVAO"];
        }

        private string bienso;

        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }

        private DateTime? ngayvao;

        public DateTime? NgayVao
        {
            get { return ngayvao; }
            set { ngayvao = value; }
        }
    }
}
