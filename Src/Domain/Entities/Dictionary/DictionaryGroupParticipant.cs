using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryGroupParticipant
    {
        public DictionaryGroupParticipant()
        {
            this.SubSubjectParticipants = new List<DictionarySubSubjectParticipant>();
            this.UserParticipants = new List<DictionaryUserParticipant>();
        }
        public Guid GroupParticipantId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<DictionarySubSubjectParticipant> SubSubjectParticipants { get; set; }
        public virtual ICollection<DictionaryUserParticipant> UserParticipants { get; set; }
    }
}
