using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Элемент в компоненте
    /// </summary>
    public class Element
    {
        public Element()
        {
            this.ComponentElements = new List<ComponentElement>();
            this.DefaultUserSettings = new List<DefaultUserSettings>();
            this.UserSettings = new List<UserSettings>();
            this.ElementProperties = new List<ElementProperty>();
            this.ElementDefaultValues = new List<ElementDefaultValue>();
        }

        public Guid ElementId { get; set; }

        /// <summary>
        /// Системное название элемента
        /// </summary>
        public string SystemName { get; set; }

        public string Type { get; set; }

        public virtual ICollection<ComponentElement> ComponentElements { get; set; }

        public virtual ICollection<DefaultUserSettings> DefaultUserSettings { get; set; }

        public virtual ICollection<UserSettings> UserSettings { get; set; }

        public virtual ICollection<ElementProperty> ElementProperties { get; set; }

        public virtual ICollection<ElementDefaultValue> ElementDefaultValues { get; set; }
    }
}
