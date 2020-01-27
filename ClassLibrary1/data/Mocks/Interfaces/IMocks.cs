using Api.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines.data.Mocks
{
    interface IMocks
    {
        public IEnumerable<Lead> Leads { get; }
        public void AddLead(Lead p);
        public void UpdateLead(int id, Lead p);
        public IEnumerable<Lead> DeleteLead(int id);
        public IEnumerable<Lead> GetAllLeads();
        public Lead GetLeadById(int id);
    }
}
