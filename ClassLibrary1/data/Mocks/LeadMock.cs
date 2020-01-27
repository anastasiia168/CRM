using Api.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines.data.Mocks
{
    class LeadMock : IMocks
    {
        private static List<Lead> _leads = new List<Lead>
        {
            new Lead (
                        1,
                        "ADAM",
                        "BOJIY",
                        "12",
                        "12",
                        5000,
                        "c@a",
                        1,
                        "c1",
                        5000,
                        true
                    ),
              new Lead (
                        1,
                        "ADAM",
                        "BOJIY",
                        "12",
                        "12",
                        5000,
                        "c@a",
                        1,
                        "c1",
                        5000,
                        true
                    )
        };



        public IEnumerable<Lead> Leads
        {
            get
            {
                return _leads;
            }
        }

        public void AddLead(Lead p)
        {
            _leads.Add(p);
        }

        public IEnumerable<Lead> DeleteLead(int id)
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

        public IEnumerable<Lead> GetAllLeads()
        {
            return _leads;
        }

        public Lead GetLeadById(int id)
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

        public void UpdateLead(int id, Lead p)
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
