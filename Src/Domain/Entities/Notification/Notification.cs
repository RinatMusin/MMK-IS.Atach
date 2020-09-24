using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Notification
{
    public class Notification
    {
        public Notification()
        {
            Templates = new List<NotificationTemplate>();
        }
        public Guid NotificationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NotificationTemplate> Templates { get; set; }
    }
}
