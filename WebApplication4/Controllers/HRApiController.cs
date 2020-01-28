using busines;
using Microsoft.AspNetCore.Mvc;

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
    }
}

