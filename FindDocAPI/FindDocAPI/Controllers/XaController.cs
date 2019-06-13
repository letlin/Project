using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDocAPI.Models;
using FindDocAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindDocAPI.Controllers
{       
    [Route("api/[controller]")]
    [ApiController]
    public class XaController : ControllerBase
    {
        [HttpGet]
        public List<Xa> Get()
        {
            List<Xa> result = new List<Xa>();
            result = DiaChiServices.Instance.getXa();

            return result;
        }

        [HttpGet("{id}")]
        public List<Xa> Get(int id)
        {
            List<Xa> result = new List<Xa>();
            result = DiaChiServices.Instance.getXa(id);

            return result;
        }
    }
}