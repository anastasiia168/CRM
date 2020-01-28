using System.Collections.Generic;
using busines;
using data;
using data.Mocks;
using data.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private  IObject<Lead> _leads;

        Translator_api translator = new Translator_api();

        public LeadController(IObject<Lead> lead)
        {
            _leads = lead;
        }

        // GET: api/Lead
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lead/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lead
        // FromBody необработанная строка JSON {"FName": "Name","SName": "Surname", "DateBirthday": "12", "DateRegistration": "12", 
        // "Numder": "9215000", "EMail": "c@a", "IdCourse": "1",
        // "GroupeName": "c1", "IdStatus": "5000"}
        [HttpPost]
        public string Post([FromBody] object value)
        {
            Lead newLead = translator.ObjectToLead(value);
            newLead.IdStatus = _leads.Count + 1;
            newLead.AccessStatus = true;

            _leads.AddObject(newLead);

            //need to return all list of leads
            return "Add new Lead. Id=" + newLead.IdStatus;
            //return translator.ShowAll();  
        }

        // PUT: api/Lead/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
