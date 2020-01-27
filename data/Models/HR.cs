using data.Models;
using System;

namespace Api.data
{
    public class HR : IDataBase
    {
        public int IdHR { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }

        public HR(int _idHR, string _fName, string _sName )
        {
            IdHR = _idHR;
            FName = _fName;
            SName = _sName;
        }


    }
}
