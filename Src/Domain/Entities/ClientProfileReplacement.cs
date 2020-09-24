using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ClientProfileReplacement
    {
        public Guid ReplacementId { get; set; }
        public Guid UserReplacementId { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDisabled { get; set; }

        public virtual ClientProfile User { get; set; }
        public virtual ClientProfile UserReplacement { get; set; }
    }
}
