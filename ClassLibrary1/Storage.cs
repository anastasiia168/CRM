using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace busines
{
    public class Storage
    {
        Translator_data translator = new Translator_data();
        public IEnumerable<IDataBase> ShowAll()
        {


            translator.ShowAll();
            return new List<IDataBase>();
        }
    }
}
