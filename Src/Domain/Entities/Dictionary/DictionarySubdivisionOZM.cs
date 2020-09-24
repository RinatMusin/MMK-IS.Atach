using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionarySubdivisionOZM
    {
        /// <summary>
        /// словарь подразделения ОЗМ
        /// </summary>
        public Guid SubdivisionOZMId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
