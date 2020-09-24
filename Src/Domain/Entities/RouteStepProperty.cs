using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteStepProperty
    {
        public Guid RouteStepPropertyId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid RouteStepId { get; set; }

        public string Value { get; set; }

        public virtual DictionaryProperty DictionaryProperty { get; set; }
        public virtual RouteStep RouteStep { get; set; }
    }
}
