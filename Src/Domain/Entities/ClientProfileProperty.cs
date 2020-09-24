using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ClientProfileProperty
    {
        /// <summary>
        /// Id свойства
        /// </summary>
        public Guid ClientProfilePropertyId { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid ClientProfileId { get; set; }

        /// <summary>
        /// Название свойства 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// значение свойства
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public virtual ClientProfile ClientProfile { get; set; }


    }
}
