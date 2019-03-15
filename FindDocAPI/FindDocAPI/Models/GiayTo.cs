using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Models
{
    public class GiayTo
    {
        private int maGiayTo;
        private DateTime ngayNhat;
        private int maXa;
        private string ghiChu;
        private Boolean trangThai;
        private string hinhAnh;
        private int maNguoiNhat;
        private int maLoai;

        public int MaGiayTo { get => maGiayTo; set => maGiayTo = value; }
        public DateTime NgayNhat { get => ngayNhat; set => ngayNhat = value; }
        public int MaXa { get => maXa; set => maXa = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int MaNguoiNhat { get => maNguoiNhat; set => maNguoiNhat = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
    }
}
