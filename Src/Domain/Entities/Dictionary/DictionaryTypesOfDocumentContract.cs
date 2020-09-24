using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    // Типы документа. Типовой нетиповой
    public class DictionaryTypesOfDocumentContract
    {
        public DictionaryTypesOfDocumentContract()
        {
            this.SubSubjects = new List<DictionarySubSubject>();
        }
        public Guid TypeOfDocumentContractId { get; set; }
        public string TypeOfDocumentContract { get; set; }

        public ICollection<DictionarySubSubject> SubSubjects { get; set; }
    }
}
