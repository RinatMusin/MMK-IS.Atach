using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ApplicationType
    {
        public int ApplicationTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
