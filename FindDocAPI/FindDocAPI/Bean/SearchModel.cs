using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Bean
{
    public class SearchModel
    {
        private int maTinh;
        private int maHuyen;
        private int maXa;
        private int maLoai;
        private String ngayNhatFrom;
        private String ngayNhatTo;

        public int MaTinh { get => maTinh; set => maTinh = value; }
        public int MaHuyen { get => maHuyen; set => maHuyen = value; }
        public int MaXa { get => maXa; set => maXa = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public String NgayNhatFrom { get => ngayNhatFrom; set => ngayNhatFrom = value; }
        public String NgayNhatTo { get => ngayNhatTo; set => ngayNhatTo = value; }
    }
}
