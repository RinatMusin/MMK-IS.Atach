using System;


namespace MMK_IS.Atach.Domain.Entities
{
    public class ElementProperty
    {
        public Guid ElementPropertyId { get; set; }

        public Guid ElementId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public virtual Element Element { get; set; }
    }
}
