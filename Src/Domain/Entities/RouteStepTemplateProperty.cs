using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;


namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteStepTemplateProperty
    {
        public Guid RouteStepTemplatePropertyId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid RouteStepTemplateId { get; set; }

        public string Value { get; set; }

        public virtual DictionaryProperty DictionaryProperty { get; set; }
        public virtual RouteStepTemplate RouteStepTemplate { get; set; }
    }
}
