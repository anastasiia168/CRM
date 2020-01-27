using data.Models;
using System;

namespace Api.data
{
    public class SkillsLead : IDataBase
    {
        public int IdLead  { get; set; }
        public int IdSkills { get; set; }
       
       

        public SkillsLead(int _idLead, int _idSkills)
        {
            IdSkills = _idLead;
            IdSkills = _idSkills;
        }


    }
}
