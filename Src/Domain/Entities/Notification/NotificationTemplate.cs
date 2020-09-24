using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Notification
{
    // TODO: NofiticationTypeId + NotificationId - UNIQ INDEX
    public class NotificationTemplate
    {
        public Guid NotificationTemplateId { get; set; }
        public Guid NofiticationTypeId { get; set; }
        public Guid NotificationId { get; set; }
        public string Template { get; set; }
        public string SubjectTemplate { get; set; }

        public virtual Notification Notification { get; set; }
        public virtual NotificationType NotifiticationType { get; set; }
    }
}
