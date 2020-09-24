using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;


namespace MMK_IS.Atach.Domain.Entities
{
    public class FieldCounterPartyType
    {
        /// <summary>
        /// счетчик контрагент
        /// </summary>
        public Guid FieldCounterPartyId { get; set; }
        public Guid CounterPartyTypeId { get; set; }
        public Guid FiedId { get; set; }

        public virtual DictionaryCounterPartyType CounterPartyType { get; set; }
        public virtual Field Field { get; set; }
    }
}
