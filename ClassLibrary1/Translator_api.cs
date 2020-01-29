using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using data;


namespace busines
{
    public class Translator_api
    {
        private readonly string json;
        readonly Storage storage = new Storage();
        public string ShowAll()
        {

           
            storage.ShowAll();
            return json;
        }

        public string Update(int id, Dictionary<string, string> dict)
        {
            storage.Update(id, dict);
            return json;
        }
    }
}
