using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionarySubSubjectParticipant
    {
        public Guid SubSubjectParticipantId { get; set; }
        public Guid SubSubjectId { get; set; }
        public string SubSubjectName { get; set; }
        public Guid GroupParticipantId { get; set; }
        public string GroupParticipantName { get; set; }

        public virtual DictionarySubSubject SubSubject { get; set; }
        public virtual DictionaryGroupParticipant GroupParticipant { get; set; }
    }
}
