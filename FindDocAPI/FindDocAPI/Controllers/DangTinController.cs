using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDocAPI.Bean;
using FindDocAPI.Models;
using FindDocAPI.RespModels;
using FindDocAPI.Services;
using Microsoft.AspNetCore.Cors;
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

            duLieuLV.ListLoaiGiayTo = LoaiGiayToList;
            duLieuLV.ListTinh = TinhList;

            return duLieuLV;
        }

        [HttpGet("{id}")]
        public ActionResult<Object> Get(int id, int data)
        {
            Object result = new Object();
           
            return result;
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody] DangTinModel value)
        {
            if(DangTinService.Instance.saveMessage(value) >= 1){
                return true;
            }

            return false;
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