﻿using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.CRUD
{
    class Select : ICommand
    {
        IDataBase dataBase;

        public List<IDataBase> Execute()
        {
            return new List<IDataBase> { new Course(), new Lead() };
        }

        public void Create(Dictionary<string, string> data)
        {
            
        }
    }
}
