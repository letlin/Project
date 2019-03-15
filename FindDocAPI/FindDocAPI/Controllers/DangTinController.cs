using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FindDocAPI.Controllers
{
    [Route("dangtin/[controller]")]
    [ApiController]
    public class DangTinController : ControllerBase
    {
        // POST dangtin/dangTin
        [HttpPost]
        public ActionResult<object> Post([FromBody] object reqModel)
        {
            object obj = reqModel;

            return obj;
        }
        
    }
}