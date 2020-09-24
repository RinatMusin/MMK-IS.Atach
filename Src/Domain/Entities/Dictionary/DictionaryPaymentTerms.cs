using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    // Условия платежа
    public class DictionaryPaymentTerms
    {
        public Guid PaymentId { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentName { get; set; }
    }
}
