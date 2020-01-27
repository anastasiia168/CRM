using data.Models;
using System;

namespace Api.data
{
    public class Lead : IDataBase
    {
        public int IdLead  { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string DateBirthday { get; set; }
        public string DateRegistration { get; set; }
        public int Numder { get; set; }
        public string EMail { get; set; }
        public int  IdCourse{ get; set; }
        public string  GroupeName{ get; set; }
        public int  IdStatus{ get; set; }
        public bool  AccessStatus{ get; set; }


        public Lead(
            int _id,
            string _name,
            string _sname,
            string _dateBirthday, 
            string _dateRegistration,
            int _numder,
            string _eMail,
            int _idCourse,
            string _groupeName,
            int _idStatus,
            bool _accessStatus
            )
        {
            IdLead = _id;
            FName = _name;
            SName = _sname;
            DateBirthday = _dateBirthday;
            DateRegistration = _dateRegistration;
            Numder = _numder;
            EMail = _eMail;
            IdCourse = _idCourse;
            GroupeName = _groupeName;
            IdStatus = _idStatus;
            AccessStatus = _accessStatus;
        }


    }
}
