using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class DocumentTemplate
    {
        public Guid DocumentTemplateId { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string Name { get; set; }
        public byte[] Template { get; set; }
        public byte[] PdfTemplate { get; set; }
        public byte[] PreviewTemplate { get; set; }
        public bool IsReply { get; set; }
        public virtual DocumentType DocumentType { get; set; }

        public virtual ICollection<DictionarySubSubjectDocumentTemplate> DictionarySubSubjectDocumentTemplates { get; set; }
    }
}
