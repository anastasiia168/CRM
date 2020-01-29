using busines;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebTest
{
    [ApiController]
    [Route("[controller]")]
    public class HRApiController : ControllerBase
    {
        readonly Translator_api t = new Translator_api();
        [HttpGet]
        public string Get()
        {
            return t.ShowAll();
        }

        [HttpPost("{id}")]
        public string Update(int id, [FromBody] Dictionary<string, string> dict) 
        {
            return t.Update(id, dict);
        }
    }
}

