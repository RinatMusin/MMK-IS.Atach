using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryPropertyType
    {
        public DictionaryPropertyType()
        {
            Properties = new List<DictionaryProperty>();
        }

        public Guid PropertyTypeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<DictionaryProperty> Properties { get; set; }
    }
}
