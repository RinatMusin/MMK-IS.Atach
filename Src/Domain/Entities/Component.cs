using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Компонент на панели отображения
    /// </summary>
    public class Component
    {
        public Component()
        {
            this.ComponentElements = new List<ComponentElement>();
            this.ComponentProperties = new List<ComponentProperty>();
        }

        public Guid ComponentId { get; set; }

        public Guid ViewPanelId { get; set; }

        /// <summary>
        /// Системное название компонента
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        public virtual ViewPanel ViewPanel { get; set; }

        public virtual ICollection<ComponentElement> ComponentElements { get; set; }

        public virtual ICollection<ComponentProperty> ComponentProperties { get; set; }
    }
}
