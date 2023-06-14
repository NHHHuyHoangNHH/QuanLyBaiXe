using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DTO
{
    public class ThamSo
    {
        public ThamSo(float moctien1, float moctien2, float tienvip, float tiencocvip)
        {
            this.MocTien1 = moctien1;
            this.MocTien2 = moctien2;
            this.TienVip = tienvip;
            this.TienCocVip = tiencocvip;
        }

        public ThamSo(DataRow row)
        {
            this.MocTien1 = (float) row["MocTien1"];
            this.MocTien2 = (float)row["MocTien2"];
            this.TienVip = (float)row["TienVIP"];
            this.TienCocVip = (float)row["TienCocVIP"];
        }

        private float moctien1;

        public float MocTien1
        {
            get { return moctien1; }
            set { moctien1 = value; }
        }

        private float moctien2;

        public float MocTien2
        {
            get { return moctien2; }
            set { moctien2 = value; }
        }

        private float tienvip;

        public float TienVip
        {
            get { return tienvip; }
            set { tienvip = value; }
        }

        private float tiencocvip;

        public float TienCocVip
        {
            get { return tiencocvip; }
            set { tiencocvip = value; }
        }
    }
}
