
using System;

namespace data.Models
{
    public class Status : IDataBase
    {
        public int IdStatus  { get; set; }
        public string Name { get; set; }

        //public Status(int _idStatus, string _name)
        //{
        //    IdStatus = _idStatus;
        //    Name = _name;
        //}


    }
}
