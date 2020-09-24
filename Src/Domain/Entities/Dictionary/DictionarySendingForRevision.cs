using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    // Причины на доработку
    public class DictionarySendingForRevision
    {
        public DictionarySendingForRevision()
        {
            RouteStepNotes = new List<RouteStepNote>();
        }

        public Guid SendingForRevisionId { get; set; }
        public string Reason { get; set; }
        public string TypeOfAction { get; set; }
        public virtual ICollection<RouteStepNote> RouteStepNotes { get; set; }
    }
}
