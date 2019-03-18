using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Models
{
    public class Huyen
    {
        private int maHuyen;
        private string tenHuyen;
        private string type;
        private int maTinh;

        public int MaHuyen { get => maHuyen; set => maHuyen = value; }
        public string TenHuyen { get => tenHuyen; set => tenHuyen = value; }
        public string Type { get => type; set => type = value; }
        public int MaTinh { get => maTinh; set => maTinh = value; }
    }
}
