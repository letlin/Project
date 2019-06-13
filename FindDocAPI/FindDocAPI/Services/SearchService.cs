using FindDocAPI.Bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Services
{
    public class SearchService
    {
        private static SearchService instance;
        public static SearchService Instance {
            get
            {
                if (instance == null)
                    instance = new SearchService();
                return instance;
            }
            private set { instance = value; }
        }
        private SearchService() { }
        public List<HomeRespModel> getIfor(SearchModel data)
        {
            List<HomeRespModel> listData = new List<HomeRespModel>();

            string sqlString = @"select ngayNhat, ghiChu, tenXa, tenHuyen, tenLoai, tenTinh, hoTen, soDienThoai from GiayTo
                            inner join NguoiNhat on GiayTo.maNguoiNhat = NguoiNhat.maNguoiNhat
                            inner join LoaiGiayTo on GiayTo.maLoai = LoaiGiayTo.maLoai
                            inner join Xa on GiayTo.maXa = Xa.maXa
                            inner join Huyen on Huyen.maHuyen = Xa.maHuyen
                            inner join Tinh on Tinh.maTinh = Huyen.maTinh
                            where Xa.maXa ='"+ data.MaXa + "' or LoaiGiayTo.maLoai = '" + data.MaLoai+ "' or GiayTo.ngayNhat BETWEEN '" + data.NgayNhatFrom + "' and '"+ data.NgayNhatTo + "'";

            DataTable dt = DataProvider.Instance.LoadAllTable(sqlString);

            foreach (DataRow row in dt.Rows)
            {
                HomeRespModel itemT = new HomeRespModel();

                itemT.NgayNhat = Convert.ToDateTime(row["ngayNhat"].ToString());
                itemT.GhiChu = row["ghiChu"].ToString();
                itemT.TenXa = row["tenXa"].ToString();
                itemT.TenHuyen = row["tenHuyen"].ToString();
                itemT.TenLoai = row["tenLoai"].ToString();
                itemT.TenTinh = row["tenTinh"].ToString();
                itemT.HoTen = row["hoTen"].ToString();
                itemT.SoDienThoai = row["soDienThoai"].ToString();

                listData.Add(itemT);
            }
            return listData;

        }
    }
}
