using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.Mocks
{
    public interface IMocks<T>
    {
        //public IEnumerable<T> Objects { get; }
        public void AddObject(T p);
        public void UpdateObject(int id, T p);
        public IEnumerable<T> DeleteObject(int id);
        public IEnumerable<T> GetAllObjects();
        public T GetObjectById(int id);
        
    }
}
