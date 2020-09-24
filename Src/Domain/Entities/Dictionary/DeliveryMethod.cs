using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    /// <summary>
    /// способ доставки
    /// </summary>
    public class DeliveryMethod
    {
        public Guid DeliveryMethodId { get; set; }
        public string Name { get; set; }
        public string DeliveryMethodType { get; set; }

    }
}
