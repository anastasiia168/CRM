using data.Mocks;
using data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace busines
{
    public class Translator_data
    {
        private readonly IMocks<Lead> _lead = new LeadMock();
        public IEnumerable<IDataBase> ShowAll()
        {

            IEnumerable<Lead> leads = _lead.GetAllObjects();
            return leads;
        }
      
        public Lead ShowObjectById(int id)
        {

            Lead lead = _lead.GetObjectById(id);
            return lead;
        }

        public IEnumerable<IDataBase> Delete(int id)
        {
            IEnumerable<Lead> leads = _lead.DeleteObject(id);
            return leads;
        }
    }
}
