using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionarySubSubjectGroupCFO
    {
        public Guid SubSubjectGroupCFOId { get; set; }
        public Guid GroupCFOId { get; set; }
        public Guid SubSubjectId { get; set; }

        public virtual DictionaryGroupCFO GroupCFO { get; set; }
        public virtual DictionarySubSubject SubSubject { get; set; }
    }
}
