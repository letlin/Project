using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDocAPI.Models;
using FindDocAPI.RespModels;
using FindDocAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindDocAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DangTinController : ControllerBase
    {
        // GET /dangtin
        [HttpGet]
        public DangTinRespModel Get()
        {
            DangTinRespModel duLieuLV = new DangTinRespModel();
        
            List<LoaiGiayTo> LoaiGiayToList = LoaiGiayToServices.Instance.getLoaiGiayTo();
            List<Tinh> TinhList = DiaChiServices.Instance.getTinh();
            List<Huyen> HuyenList = DiaChiServices.Instance.getHuyen();
            List<Xa> XaList = DiaChiServices.Instance.getXa();

            duLieuLV.ListLoaiGiayTo = LoaiGiayToList;
            duLieuLV.ListTinh = TinhList;
            duLieuLV.ListHuyen = HuyenList;
            duLieuLV.ListXa = XaList;
            return duLieuLV;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST /dangtin
        [HttpPost]
        public int Post([FromBody] Object value)
        {
            int result = 0;
            String sqlString = "insert into LoaiGiayTo(maLoai, tenLoai) values('1', 'abcdefv')";
            result = DataProvider.Instance.ExcuteNonQuery(sqlString);

            return result;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}