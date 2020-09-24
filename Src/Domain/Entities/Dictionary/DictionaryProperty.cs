using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryProperty
    {
        public DictionaryProperty()
        {
            RouteStepTemplateProperties = new List<RouteStepTemplateProperty>();
            RouteStepProperties = new List<RouteStepProperty>();
            WorkplaceProperties = new List<WorkplaceProperty>();
            DictionaryPropertyDocumentTypes = new List<DictionaryPropertyDocumentType>();
        }

        public Guid PropertyId { get; set; }
        public Guid PropertyTypeId { get; set; }
        public string Name { get; set; }

        public virtual DictionaryPropertyType PropertyType { get; set; }
        public virtual ICollection<RouteStepProperty> RouteStepProperties { get; set; }
        public virtual ICollection<RouteStepTemplateProperty> RouteStepTemplateProperties { get; set; }
        public virtual ICollection<WorkplaceProperty> WorkplaceProperties { get; set; }
        public virtual ICollection<DictionaryPropertyDocumentType> DictionaryPropertyDocumentTypes { get; set; }
    }
}
