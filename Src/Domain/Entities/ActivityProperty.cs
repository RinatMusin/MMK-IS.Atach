using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// свойство действия
    /// </summary>
    public class ActivityProperty
    {
        public Guid ActivityPropertyId { get; set; }
        public Guid ActivityId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
