using System;
using System.Collections.Generic;
using System.Text;
using data.Models;

namespace data.CRUD
{
    interface ICommand
    {
        List<IDataBase> Execute();
        void Create(Dictionary<string, string> data);
    }
}
