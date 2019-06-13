using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDocAPI.Bean;
using FindDocAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindDocAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<HomeRespModel> Get()
        {
            return HomeService.Instance.getIfor();
        }
    }
}