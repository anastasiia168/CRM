using data.Models;
using System;

namespace Api.data
{
    public class Skills : IDataBase
    {
        public int IdSkills  { get; set; }
        public string NameSkills { get; set; }
       
       

        public Skills(int _idSkills, string _nameSkills)
        {
            IdSkills = _idSkills;
            NameSkills = _nameSkills;
        }


    }
}
