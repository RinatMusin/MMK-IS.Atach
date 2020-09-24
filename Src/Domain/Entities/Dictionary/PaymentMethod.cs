using System;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class PaymentMethod
    {
        /// <summary>
        /// способ оплаты
        /// </summary>
        public Guid PaymentMethodId { get; set; }
        public string Name { get; set; }
    }
}