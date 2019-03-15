using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Models
{
    public class Tinh
    {
        private int maTinh;
        private string tenTinh;
        private string type;
       
        public string Type { get => type; set => type = value; }
        public int MaTinh { get => maTinh; set => maTinh = value; }
        public string TenTinh { get => tenTinh; set => tenTinh = value; }
    }
}
