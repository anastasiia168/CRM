using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.busines;
using Api.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HRApiController : ControllerBase
    {
        Translator t = new Translator();
        [HttpGet]
        public string Get()
        {
            return t.ShowAll();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return t.ShowEl(id) ;
        }

        [HttpGet]
        [Route ("sort")]
        public string Get([FromBody] string[] sort)
        {
            return t.SortField(sort);
        }

        [HttpGet]
        [Route("filtr")]
        public string GetFiltr([FromBody] string[] filtr)
        {
            return t.FiltrField(filtr);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return t.DeleteEl(id);
        }

        [HttpPut]
        public string Put(int id, string fname, string sName, int age, string sity, int wages)
        {
            Person person = new Person(id, fname, sName, age, sity, wages);
            return t.InsertEl(person);
        }

        [HttpPost]
        public string Post(int id, [FromBody] string[] change)
        {
           return t.UpdateEl(id, change);
        }
    }
}

// ["123qwe", "" "aa", "", "", "213312"]