using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Свойство компонента
    /// </summary>
    public class ComponentProperty
    {
        public Guid ComponentPropertyId { get; set; }

        public Guid ComponentId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public virtual Component Component { get; set; }
    }
}
