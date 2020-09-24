using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    // Вид договора
    public class DictionaryKindOfDocument
    {
        public Guid KindOfDocumentId { get; set; }
        public string KindOfDocument { get; set; }

        public string SAPCode { get; set; }
    }
}
