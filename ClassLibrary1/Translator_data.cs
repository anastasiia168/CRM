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
        private readonly IMocks<Lead> _lead;
        public IEnumerable<IDataBase> ShowAll()
        {

            IEnumerable<Lead> leads = _lead.Objects;
            return leads;
        }
    }
}
