using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Bean
{
    public class DangTinReqModel
    {
        private int type;
        private int maTinh;
        private int maHuyen;

        public int Type { get => type; set => type = value; }
        public int MaTinh { get => maTinh; set => maTinh = value; }
        public int MaHuyen { get => maHuyen; set => maHuyen = value; }
    }
}
