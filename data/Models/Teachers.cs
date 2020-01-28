using System;


namespace data.Models
{
    public class Teachers : IDataBase
    {
        public int IdTeachers { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
       
       

        //public Teachers(int _idTeachers, string _fName, string _sName )
        //{
        //    IdTeachers = _idTeachers;
        //    FName = _fName;
        //    SName = _sName;
        //}


    }
}
