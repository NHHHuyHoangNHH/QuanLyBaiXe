﻿using QuanLyBaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiXe.DAO
{
    public class LoggDAO
    {
        private static LoggDAO instance;

        public static LoggDAO Instance
        {
            get { if (instance == null) instance = new LoggDAO(); return LoggDAO.instance; }
            private set { LoggDAO.instance = value; }
        }

        public static int Width = 90;
        public static int Height = 90;

        private LoggDAO() { }

        public int AddLogg(string thongtin)
        {   
            return DataProvider.Instance.ExecuteNonQuery("exec PDInsertLOGG @ThongTin", new object[] { thongtin });
        }

        public List<Logg> GetLogg(DateTime? First, DateTime? Second)
        {
            List<Logg> LoggList = new List<Logg>();

            DataTable data = DataProvider.Instance.ExecuteQuery("exec PDGetLOGG @First , @Second", new object[] { First, Second } );

            foreach (DataRow item in data.Rows)
            {
                Logg Logg = new Logg(item);
                LoggList.Add(Logg);
            }

            return LoggList;
        }

        public List<Logg> LoadLogg()
        {
            List<Logg> LoggList = new List<Logg>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LOGG");

            foreach (DataRow item in data.Rows)
            {
                Logg Logg = new Logg(item);
                LoggList.Add(Logg);
            }

            return LoggList;
        }
    }
}
