using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryCounterPartyType
    {

        public DictionaryCounterPartyType()
        {
            this.DictionaryCounterParties = new List<DictionaryCounterParty>();
            this.FieldCounterParties = new List<FieldCounterPartyType>();

        }
        /// <summary>
        /// ИДентификатор группы контрагента
        /// </summary>
        public Guid CounterPartyTypeId { get; set; }

        /// <summary>
        /// Название типа контрагента
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<DictionaryCounterParty> DictionaryCounterParties { get; set; }
        /// <summary>
        /// поля контрагента
        /// </summary>
        public virtual ICollection<FieldCounterPartyType> FieldCounterParties { get; set; }

    }
}
