using FindDocAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.RespModels
{
    public class DangTinRespModel
    {
        private List<LoaiGiayTo> listLoaiGiayTo;
        private List<Tinh> listTinh;
        private List<Huyen> listHuyen;
        private List<Xa> listXa;

        public List<LoaiGiayTo> ListLoaiGiayTo { get => listLoaiGiayTo; set => listLoaiGiayTo = value; }
        public List<Tinh> ListTinh { get => listTinh; set => listTinh = value; }
        public List<Huyen> ListHuyen { get => listHuyen; set => listHuyen = value; }
        public List<Xa> ListXa { get => listXa; set => listXa = value; }
    }
}
