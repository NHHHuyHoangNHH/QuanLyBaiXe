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
        public ThamSo(int moctien1, int moctien2, int tienvip, int tiencocvip, int moctg1, int moctg2, int moctg3)
        {
            this.MocTien1 = moctien1;
            this.MocTien2 = moctien2;
            this.TienVip = tienvip;
            this.TienCocVip = tiencocvip;
            this.MocThoiGian1 = moctg1;
            this.MocThoiGian2 = moctg2;
            this.MocThoiGian3 = moctg3;

        }

        public ThamSo(DataRow row)
        {
            this.MocTien1 = (int)row["MocTien1"];
            this.MocTien2 = (int)row["MocTien2"];
            this.TienVip = (int)row["TienVIP"];
            this.TienCocVip = (int)row["TienCocVIP"];
            this.MocThoiGian1 = (int)row["MocTG1"];
            this.MocThoiGian2 = (int)row["MocTG2"];
            this.MocThoiGian3 = (int)row["MocTG3"];
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

        private float moctg1;
        public float MocThoiGian1
        {
            get { return moctg1; }
            set { moctg1 = value; }
        }

        private float moctg2;
        public float MocThoiGian2
        {
            get { return moctg2; }
            set { moctg2 = value; }
        }

        private float moctg3;
        public float MocThoiGian3
        {
            get { return moctg3; }
            set { moctg3 = value; }
        }
    }
}
