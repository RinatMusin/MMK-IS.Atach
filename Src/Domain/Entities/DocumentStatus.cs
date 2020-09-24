using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class DocumentStatus
    {
        /// <summary>
        /// статус документа
        /// </summary>
        public DocumentStatus()
        {
            this.Documents = new List<Document>();
            this.RouteStepGroups = new List<RouteStepGroup>();
        }

        public Guid DocumentStatusId { get; set; }
        public string TypeStatus { get; set; }
        public string Name { get; set; }
        public string StatusColor { get; set; }
        public string CenterPanelType { get; set; }
        public string RightPanelType { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<RouteStepGroup> RouteStepGroups { get; set; }
    }
}
