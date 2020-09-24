using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Связь Component/Element
    /// </summary>
    public class ComponentElement
    {
        public Guid ComponentElementId { get; set; }

        public Guid ComponentId { get; set; }

        public Guid ElementId { get; set; }

        public virtual Component Component { get; set; }

        public virtual Element Element { get; set; }
    }
}
