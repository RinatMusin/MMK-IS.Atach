using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryUserParticipant
    {
        public Guid UserParticipantId { get; set; }
        public Guid GroupParticipantId { get; set; }
        public string GroupParticipantName { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public virtual DictionaryGroupParticipant GroupParticipant { get; set; }
        public virtual ClientProfile User { get; set; }
    }
}
