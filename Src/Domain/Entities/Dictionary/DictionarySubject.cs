using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionarySubject
    {
        public DictionarySubject()
        {
            this.SubSubjects = new List<DictionarySubSubject>();
        }
        public Guid SubjectId { get; set; }
        public string Name { get; set; }
        public string SAPCode { get; set; }

        public virtual ICollection<DictionarySubSubject> SubSubjects { get; set; }
    }
}
