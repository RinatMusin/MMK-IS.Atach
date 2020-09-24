using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryCurrency
    {
        public Guid CurrencyId { get; set; }
        public string DigitalCode { get; set; }
        public string LetterCode { get; set; }
        public string CurrencyName { get; set; }
    }
}
