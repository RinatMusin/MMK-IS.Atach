using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryPropertyDocumentType
    {
        public Guid DictionaryPropertyDocumentTypeId { get; set; }

        public Guid PropertyId { get; set; }

        /// <summary>
        /// Id типа документа
        /// </summary>
        public Guid DocumentTypeId { get; set; }

        public virtual DictionaryProperty DictionaryProperty { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        public virtual DocumentType DocumentType { get; set; }
    }
}
