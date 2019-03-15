using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Models
{
    public class NguoiNhat
    {
        private int maNguoiNhat;
        private string hoTen;
        private int maXa;
        private string soDienThoai;

        public int MaNguoiNhat { get => maNguoiNhat; set => maNguoiNhat = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public int MaXa { get => maXa; set => maXa = value; }
    }
}
