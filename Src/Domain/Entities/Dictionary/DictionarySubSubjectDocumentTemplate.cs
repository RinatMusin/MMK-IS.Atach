using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionarySubSubjectDocumentTemplate
    {
        public Guid SubSubjectDocumentTemplateId { get; set; }
        public Guid SubSubjectId { get; set; }
        public Guid DocumentTemplateId { get; set; }

        public virtual DocumentTemplate DocumentTemplate { get; set; }
        public virtual DictionarySubSubject SubSubject { get; set; }
    }
}
