using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using data;
using data.Models;
using Newtonsoft.Json;

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

        public Lead ObjectToLead(object obj)
        {
            string str = obj.ToString();
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(str);  

            return new Lead
            {
                FName = (dictionary.ContainsKey("FName")) ? dictionary["FName"] : "",
                SName = (dictionary.ContainsKey("SName")) ? dictionary["SName"] : "",
                DateBirthday = (dictionary.ContainsKey("DateBirthday")) ? dictionary["DateBirthday"] : "",
                DateRegistration = (dictionary.ContainsKey("DateRegistration")) ? dictionary["DateRegistration"] : "",
                Numder = (dictionary.ContainsKey("Numder")) ? StringToInt(dictionary["Numder"]) : 0,
                EMail = (dictionary.ContainsKey("EMail")) ? dictionary["EMail"] : "",
                IdCourse = (dictionary.ContainsKey("IdCourse")) ? StringToInt(dictionary["IdCourse"]) : 0,
                GroupeName = (dictionary.ContainsKey("FName")) ? dictionary["FName"] : "",
                IdStatus = (dictionary.ContainsKey("IdStatus")) ? StringToInt(dictionary["IdStatus"]) : 0
            };
        }

        private int StringToInt(string str)
        {            
            return int.TryParse(str, out int number) ? number : 0;
        }
    }
}
