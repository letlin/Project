using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Bean
{
    public class DangTinModel
    {
        private string hoTen;
        private string soDienThoai;
        private int diaChiNguoiNhat;
        private int maLoai;
        private DateTime ? ngayNhat;
        private int noiNhat;
        private string ghiChu;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public int DiaChiNguoiNhat { get => diaChiNguoiNhat; set => diaChiNguoiNhat = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public DateTime? NgayNhat { get => ngayNhat; set => ngayNhat = value; }
        public int NoiNhat { get => noiNhat; set => noiNhat = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
