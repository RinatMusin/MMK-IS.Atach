using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Совйства штатных позицый
    /// </summary>
    public class WorkplaceProperty
    {
        public Guid WorkplacePropertyId { get; set; }
        public Guid DictionaryPropertyId { get; set; }
        public Guid WorkplaceId { get; set; }

        public virtual DictionaryProperty DictionaryProperty { get; set; }

        public virtual Workplace Workplace { get; set; }

    }
}
