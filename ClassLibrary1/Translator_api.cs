using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using data;


namespace busines
{
    public class Translator_api
    {
        string json;
        Storage storage = new Storage();
        public string ShowAll()
        {

            //json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, null, null));
            storage.ShowAll();
            return json;
        }
    }
}
