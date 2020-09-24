using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class WorkplaceUser
    {
        public Guid WorkplaceUserId { get; set; }
        public Guid WorkplaceId { get; set; }
        public Guid UserId { get; set; }
        /// <summary>
        /// признак основого рабочего места
        /// </summary>
        public bool IsMainWorkplace { get; set; }
        public virtual ClientProfile User { get; set; }
        public virtual Workplace Workplace { get; set; }
    }
}
