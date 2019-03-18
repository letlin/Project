using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Models
{
    public class Xa
    {
        private int maXa;
        private string tenXa;
        private string type;
        private int maHuyen;

        public int MaXa { get => maXa; set => maXa = value; }
        public string TenXa { get => tenXa; set => tenXa = value; }
        public string Type { get => type; set => type = value; }
        public int MaHuyen { get => maHuyen; set => maHuyen = value; }
    }
}
