using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Notification
{
    public class NotificationType
    {
        public NotificationType()
        {
            NotificationTemplates = new List<NotificationTemplate>();
        }

        public Guid NotificationTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
