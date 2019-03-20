using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDocAPI.Bean;
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
            //
            //

            duLieuLV.ListLoaiGiayTo = LoaiGiayToList;
            duLieuLV.ListTinh = TinhList;
            //duLieuLV.ListHuyen = HuyenList;
           // duLieuLV.ListXa = XaList;
            return duLieuLV;
        }

        // GET /dangtin/5
        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id, int data)
        {
            Object result = new Object();
            if(id == 2)
            {
                List<Huyen> HuyenList = DiaChiServices.Instance.getHuyen();
                result =  HuyenList;
            }
            else
            {
                List<Xa> XaList = DiaChiServices.Instance.getXa();
                result = XaList;
            }
            return result;
        }

        // POST /dangtin
        [HttpPost]
        public ActionResult<Object> Post([FromBody] Object reqModel)
        {
            DangTinReqModel a = (DangTinReqModel)reqModel;
            Object obj = reqModel;
            return obj;

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