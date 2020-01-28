using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace busines
{
    public class Storage
    {
        readonly Translator_data translator = new Translator_data();
        public IEnumerable<IDataBase> ShowAll()
        {


            translator.ShowAll();
            return new List<IDataBase>();
        }
        public Lead ShowObjectById(int id)
        {  
            Lead lead = translator.ShowObjectById(id);

            return lead;
        }
    }
}
