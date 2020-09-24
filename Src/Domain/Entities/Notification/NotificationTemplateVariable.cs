using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities.Notification
{
    public class NotificationTemplateVariable
    {
        public Guid NotificationTemplateVariableId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
