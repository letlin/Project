using FindDocAPI.Bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Services
{
    public class DangTinService
    {
        private static DangTinService instance;
        public static DangTinService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangTinService();
                return instance;
            }
            private set { instance = value; }

        }
        private DangTinService() { }
        public int saveMessage(DangTinModel data)
        {
            Random rand = new Random();
            int step = rand.Next(0, 200000);
            // insert nguoi nhat
            string sqlStr = @"insert into NguoiNhat(maNguoiNhat, hoTen, maXa, soDienThoai) values('"+ step + "',N'"+ data.HoTen + "', '"+ data.DiaChiNguoiNhat + "', '" + data.SoDienThoai + "')";
            int b = DataProvider.Instance.ExcuteNonQuery(sqlStr);
            // insert giay to
            string sqlString = @"insert into GiayTo(maGiayTo, ngayNhat, maXa, ghiChu, maNguoiNhat, maLoai) values('" + step + "','"+ data.NgayNhat + "','"+ data.NoiNhat + "',N'"+ data.GhiChu + "','"+ step + "','"+ data.MaLoai + "')" ;
            int c = DataProvider.Instance.ExcuteNonQuery(sqlString);

            return c + b;
        }
    }
}
