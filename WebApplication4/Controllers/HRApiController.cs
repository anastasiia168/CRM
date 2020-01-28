using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data;
using busines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebTest
{
    [ApiController]
    [Route("[controller]")]
    public class HRApiController : ControllerBase
    {
        Translator_api t = new Translator_api();
        [HttpGet]
        public string Get()
        {
            return t.ShowAll();
        }

        
    }
}

