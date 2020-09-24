using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Notification
{
    public class NotificationTemplateTag
    {
        public Guid NotificationTemplateTagId { get; set; }
        public string Name { get; set; }
        public string LeftPart { get; set; }
        public string RightPart { get; set; }
    }
}
