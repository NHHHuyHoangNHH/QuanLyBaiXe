﻿using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance
        {
            get { if (instance == null) instance = new XeDAO(); return XeDAO.instance; }
            private set { XeDAO.instance = value; }
        }

        public static int Width = 90;
        public static int Height = 90;

        private XeDAO() { }

        public int AddXe(string bienso)
        {
            string query = string.Format("EXEC PDInsertXE '{0}'", bienso);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool DeteleXe(string bienso)
        {
            string query = string.Format("exec PDDeleteXE {0}", bienso);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Xe> FindXe(string bienso)
        {
            List<Xe> XeList = new List<Xe>();
            string query = string.Format("exec PDFindXE '{0}'", bienso);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Xe Xe = new Xe(item);
                XeList.Add(Xe);
            }

            return XeList;
        }

        public DataTable SearchXe(string bienso)
        {
            string query = string.Format("exec PDFindXE '{0}'", bienso);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadXeTable()
        {
            string query = "SELECT BienSo, CONVERT(nvarchar(19), ThoiGian, 103) + ' ' + CONVERT(nvarchar(8), ThoiGian, 108) AS ThoiGian  FROM Xe ORDER BY MONTH(ThoiGian) DESC, DAY(ThoiGian) DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetMoney(string BienSo)
        {
            string query =string.Format("exec GetMoney '{0}'", BienSo);
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
