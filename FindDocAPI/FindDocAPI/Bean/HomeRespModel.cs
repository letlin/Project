using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Bean
{
    public class HomeRespModel
    {
        private DateTime ngayNhat;
        private string ghiChu;
        private string tenXa;
        private string tenHuyen;
        private string tenLoai;
        private string tenTinh;
        private string hoTen;
        private string soDienThoai;

        public DateTime NgayNhat { get => ngayNhat; set => ngayNhat = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TenXa { get => tenXa; set => tenXa = value; }
        public string TenHuyen { get => tenHuyen; set => tenHuyen = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public string TenTinh { get => tenTinh; set => tenTinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
