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
    [Route("api/[controller]")]
    [ApiController]
    public class HuyenController : ControllerBase
    {
        [HttpGet]
        public List<Huyen> Get()
        {
            List<Huyen> result = new List<Huyen>();
            result = DiaChiServices.Instance.getHuyen();

            return result;
        }
        [HttpGet("{id}")]
        public List<Huyen> Get(int id)
        {
            List<Huyen> result = new List<Huyen>();
            result = DiaChiServices.Instance.getHuyen(id);

            return result;
        }
    }
}