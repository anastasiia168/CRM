using data.Models;
using System.Collections.Generic;

namespace data.Mocks
{
    public class LeadMock : IObject<Lead>
    {
        private static List<Lead> _leads = new List<Lead>
        {
            new Lead {
                        IdLead = 1,
                        FName = "ADAM",
                        SName = "BOJIY",
                        DateBirthday = "12",
                        DateRegistration = "12",
                        Numder = 5000,
                        EMail = "c@a",
                        IdCourse = 1,
                        GroupeName = "c1",
                        IdStatus = 5000,
                        AccessStatus = true
            },
             new Lead {
                        IdLead = 1,
                        FName = "ADAM",
                        SName = "BOJIY",
                        DateBirthday = "12",
                        DateRegistration = "12",
                        Numder = 5000,
                        EMail = "c@a",
                        IdCourse = 1,
                        GroupeName = "c1",
                        IdStatus = 5000,
                        AccessStatus = true
            },
        };



        public IEnumerable<Lead> Objects
        {
            get
            {
                return _leads;
            }
        }

        public int Count => _leads.Count;

        public void AddObject(Lead p)
        {
            _leads.Add(p);
        }

        public IEnumerable<Lead> DeleteObject(int id)
        {

            Lead p = null;
            foreach (var item in _leads)
            {
                if (item.IdLead == id)
                {
                    p = item;
                }
            }

            if (p != null)
            {
                _leads.Remove(p);
            }
            return _leads;
        }

        public IEnumerable<Lead> GetAllObjects()
        {
            return _leads;
        }

        public Lead GetObjectById(int id)
        {
            foreach (var item in _leads)
            {

                if (item.IdLead == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateObject(int id, Lead p)
        {
            foreach (var item in _leads)
            {
                if (item.IdLead == id)
                {
                    item.FName = p.FName;
                    item.SName = p.SName;
                    item.DateBirthday = p.DateBirthday;
                    item.DateRegistration = p.DateRegistration;
                    item.Numder = p.Numder;
                    item.EMail = p.EMail;
                    item.IdCourse = p.IdCourse;
                    item.GroupeName = p.GroupeName;
                    item.IdStatus = p.IdStatus;
                }
            }
        }
    }
}
