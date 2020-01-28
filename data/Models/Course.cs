
using System;

namespace data.Models
{
    public class Course: IDataBase
    {
        public int IdCourse  { get; set; }
        public string Name { get; set; }
        public string CourseInfo { get; set; }
       

        //public Course(int _id, string _name, string _courseInfo)
        //{
        //    IdCourse = _id;
        //    Name = _name;
        //    CourseInfo = _courseInfo;
        //}


    }
}
