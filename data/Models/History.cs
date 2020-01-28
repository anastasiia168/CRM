
using System;

namespace data.Models
{
    public class History : IDataBase
    {
        public int IdLead  { get; set; }
        public string HistoryText { get; set; }
       
       

        //public History(int _idLead, string _historyText)
        //{
        //    IdLead = _idLead;
        //    HistoryText = _historyText;
        //}


    }
}
