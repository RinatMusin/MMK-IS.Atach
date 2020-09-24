using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// действие
    /// </summary>
    public class Activity : IEquatable<Activity>
    {
        public Activity()
        {
            this.ApplicationRoleActivities = new HashSet<ApplicationRoleActivity>();
            this.DocumentTypeActivities = new HashSet<DocumentTypeActivity>();
            this.TaskStatusActivities = new HashSet<TaskStatusActivity>();
            this.ActivityProperties = new HashSet<ActivityProperty>();
        }

        public Guid ActivityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationRoleActivity> ApplicationRoleActivities { get; set; }
        public virtual ICollection<DocumentTypeActivity> DocumentTypeActivities { get; set; }
        public virtual ICollection<TaskStatusActivity> TaskStatusActivities { get; set; }
        public virtual ICollection<ActivityProperty> ActivityProperties { get; set; }

        public bool Equals(Activity other)
        {
            return ActivityId == other.ActivityId;
        }

        public override bool Equals(object obj)
        {
            return obj is Activity && Equals((Activity)obj);
        }

        public override int GetHashCode() => ActivityId.GetHashCode();
    }
}
