using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Панель отображения
    /// </summary>
    public class ViewPanel
    {
        public ViewPanel()
        {
            this.Components = new List<Component>();
        }

        public Guid ViewPanelId { get; set; }

        /// <summary>
        /// Системное название панели
        /// </summary>
        public string SystemName { get; set; }

        public virtual ICollection<Component> Components { get; set; }
    }
}
