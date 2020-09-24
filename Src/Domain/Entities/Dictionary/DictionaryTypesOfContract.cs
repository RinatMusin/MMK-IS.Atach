using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    // Типы договора. Расходный доходный
    public class DictionaryTypesOfContract
    {
        public DictionaryTypesOfContract()
        {
            this.SubSubjects = new List<DictionarySubSubject>();
        }
        public Guid TypeOfContractId { get; set; }
        public string TypeOfContract { get; set; }

        public virtual ICollection<DictionarySubSubject> SubSubjects { get; set; }
    }
}
