using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class BaseModel
    {
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
