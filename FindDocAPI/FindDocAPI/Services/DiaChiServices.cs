using FindDocAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Services
{
    public class DiaChiServices
    {
        private static DiaChiServices instance;
        public static DiaChiServices Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiaChiServices();
                return instance;
            }
            private set { instance = value; }

        }

        public static object Instace { get; internal set; }

        private DiaChiServices() { }

        //Get ve table Tinh
        public List<Tinh> getTinh()
        {
            List<Tinh> lst = new List<Tinh>();

            string sqlStr = @"select * from Tinh";
            DataTable dt = DataProvider.Instance.LoadAllTable(sqlStr);

            foreach (DataRow row in dt.Rows)
            {
               Tinh itemT = new Tinh();

                itemT.MaTinh = Convert.ToInt32(row["maTinh"].ToString());
                itemT.TenTinh = row["tenTinh"].ToString();
                lst.Add(itemT);
            }
            return lst;
        }
        //Get ve table huyen
        public List<Huyen> getHuyen()
        {
            List<Huyen> lst2 = new List<Huyen>();

            string sqlStr = @"select * from Huyen";
            DataTable dt = DataProvider.Instance.LoadAllTable(sqlStr);

            foreach (DataRow row in dt.Rows)
            {
                Huyen itemT = new Huyen();

                itemT.MaHuyen = Convert.ToInt32(row["maHuyen"].ToString());
                itemT.TenHuyen = row["tenHuyen"].ToString();
                lst2.Add(itemT);
            }
            return lst2;
        }
        //Get ve table xa
        public List<Xa> getXa()
        {
            List<Xa> lst3 = new List<Xa>();

            string sqlStr = @"select * from Xa";
            DataTable dt = DataProvider.Instance.LoadAllTable(sqlStr);

            foreach (DataRow row in dt.Rows)
            {
                Xa itemT = new Xa();

                itemT.MaXa = Convert.ToInt32(row["maXa"].ToString());
                itemT.TenXa = row["tenXa"].ToString();
                lst3.Add(itemT);
            }
            return lst3;
        }

    }
}
