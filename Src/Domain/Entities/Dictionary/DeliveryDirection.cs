using System;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DeliveryDirection
    {
        /// <summary>
        /// направление доставки
        /// </summary>
        public Guid DeliveryDirectionId { get; set; }
        public string Name { get; set; }
    }
}