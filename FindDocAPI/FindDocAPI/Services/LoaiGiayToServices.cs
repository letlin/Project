using FindDocAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Services
{
    public class LoaiGiayToServices
    {
        private static LoaiGiayToServices instance;
        public static LoaiGiayToServices Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiGiayToServices();
                return instance;
            }
            private set { instance = value; }

        }
        private LoaiGiayToServices() { }

        //Get loai giay to
        public List<LoaiGiayTo> getLoaiGiayTo()
        {
            List<LoaiGiayTo> lst = new List<LoaiGiayTo>();
            
            string sqlStr = @"select * from LoaiGiayTo";
            DataTable dt = DataProvider.Instance.LoadAllTable(sqlStr);

            foreach (DataRow row in dt.Rows)
            {
                LoaiGiayTo itemLGT = new LoaiGiayTo();

                itemLGT.MaLoai = Convert.ToInt32(row["maLoai"].ToString());
                itemLGT.TenLoai = row["tenLoai"].ToString();
                lst.Add(itemLGT);
            }
            return lst;
        }


    }
}
