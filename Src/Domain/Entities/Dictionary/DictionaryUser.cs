using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryUser
    {
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public virtual DictionaryOrganization Organization { get; set; }
    }
}
