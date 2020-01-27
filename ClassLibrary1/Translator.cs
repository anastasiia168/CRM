using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Api.data;

namespace Api.busines
{
    public class Translator
    {
        DataSource ds = new DataSource();
        string command, json;


        public string ShowAll()
        {
            command = "GET";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, null, null));
            return json;
        }

        public string DeleteEl(int id)
        {
            command = "DELETE";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, id, null, null));
            return json;
        }

        public string ShowEl(int id)
        {
            command = "GET/id";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, id, null, null));
            return json;
        }

        public string InsertEl(Person _person)
        {
            command = "INSERT";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, _person, null));
            return json;
        }

        public string UpdateEl(int id, string[] fieldChange)
        {
            command = "UPDATE";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, id, null, fieldChange));
            return json;
        }

        public string SortField(string[] sort)
        {
            command = "SORT";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, null, sort));
            return json;
        }


        public string FiltrField(string[] filtr)
        {
            command = "FILTR";
            json = JsonSerializer.Serialize<List<Person>>(ds.GetSQL(command, 0, null, filtr));
            return json; 
        }
    }
}
