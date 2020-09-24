using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryOrganization
    {
        public DictionaryOrganization()
        {
            this.Users = new List<DictionaryUser>();
        }
        public Guid OrganizationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DictionaryUser> Users { get; set; }
    }
}
