using data.Models;
using System;

namespace Api.data
{
    public class Group : IDataBase
    {
        public string GroupName  { get; set; }
        public int IdCourse { get; set; }
        public string StartDate { get; set; }
        public int IdTeacher { get; set; }
        public string Log { get; set; }
       

        public Group(string _groupName, int _idCourse, string _startDate, int _idTeacher, string _log)
        {
            GroupName = _groupName;
            IdCourse = _idCourse;
            StartDate = _startDate;
            IdTeacher = _idTeacher;
            Log = _log;
        }


    }
}
