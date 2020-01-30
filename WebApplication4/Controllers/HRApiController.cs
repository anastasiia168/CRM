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
        [Route("/")]
        public string Get()
        {
            return t.ShowAll();
        }
        [HttpGet]
        [Route("/{id}")]
        public string Get(int id)
        {
            return t.ShowObjectById(id);
        }
        
        [HttpDelete]
        [Route("/{id}")]
        public string Delete(int id)
        {
            return t.Delete(id);
        }
    }
}

