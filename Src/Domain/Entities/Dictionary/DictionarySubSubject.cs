using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionarySubSubject
    {
        public DictionarySubSubject()
        {
            this.SubSubjectParticipants = new List<DictionarySubSubjectParticipant>();
            this.SubSubjectGroupCFOs = new List<DictionarySubSubjectGroupCFO>();
        }

        public Guid SubSubjectId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid TypeOfDocumentContractId { get; set; }
        public Guid? TypeOfContractId { get; set; }
        public string SubSubjectName { get; set; }
        public bool ReglamentF223 { get; set; }

        public virtual DictionarySubject Subject { get; set; }
        public virtual DictionaryTypesOfDocumentContract TypesOfDocumentContract { get; set; }
        public virtual DictionaryTypesOfContract TypeOfContract { get; set; }

        public virtual ICollection<DictionarySubSubjectParticipant> SubSubjectParticipants { get; set; }
        public virtual ICollection<DictionarySubSubjectGroupCFO> SubSubjectGroupCFOs { get; set; }

        public virtual ICollection<DictionarySubSubjectDocumentTemplate> SubSubjectDocumentTemplates { get; set; }

    }
}
