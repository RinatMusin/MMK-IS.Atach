using System;


namespace MMK_IS.Atach.Domain.Entities
{
    public class ElementDefaultValue
    {
        public Guid ElementDefaultValueId { get; set; }

        public Guid ElementId { get; set; }

        public string Value { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Element Element { get; set; }
    }
}
