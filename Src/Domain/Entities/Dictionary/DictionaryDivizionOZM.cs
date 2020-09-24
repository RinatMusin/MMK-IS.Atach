using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryDivizionOZM
    {
        public Guid DictionaryDivizionOZMId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid EconomistId { get; set; }

        public virtual ClientProfile Economist { get; set; }

    }
}
