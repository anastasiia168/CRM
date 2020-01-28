using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using data;
using data.Models;

namespace busines
{
    public class Translator_api
    {
        private readonly string json;
        readonly Storage storage = new Storage();
        public string ShowAll()
        {

            //json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, null, null));
            storage.ShowAll();
            return json;
        }
      
        public string ShowObjectById(int id)
        {

            //json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, null, null));
            var l = storage.ShowObjectById(id);
            var jasonLead = JsonSerializer.Serialize<Lead>(l);

            return jasonLead;
        }
    }
}
