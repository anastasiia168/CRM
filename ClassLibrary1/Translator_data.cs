using data;
using data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace busines
{
    public class Translator_data
    {
        private readonly IObject<Lead> _lead;
        public IEnumerable<IDataBase> ShowAll()
        {

            IEnumerable<Lead> leads = _lead.Objects;
            return leads;
        }
    }
}
