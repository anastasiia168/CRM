using System;
using System.Collections.Generic;
using System.Text;
using data.Mocks;
using data.Models;

namespace busines
{
    public class Storage
    {
        readonly Translator_data translator = new Translator_data();
        private readonly IMocks<Lead> _lead;

        public Storage()
        {
            _lead = new LeadMock();
        }

        public IEnumerable<IDataBase> ShowAll()
        {
            translator.ShowAll();
            return new List<IDataBase>();
        }

        

        public IEnumerable<IDataBase> Update(int id, Dictionary<string, string> dict)
        {
            Lead leads = _lead.GetObjectById(id);
            foreach (KeyValuePair<string, string> keyValue in dict)
            {
                if (keyValue.Key == )
                {

                }
            }
            
            return translator.Update();
        }
    }
}
