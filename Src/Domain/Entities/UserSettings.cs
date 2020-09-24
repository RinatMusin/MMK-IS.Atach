using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Настройки для элемента, которые пользователь выбирает сам
    /// </summary>
    public class UserSettings
    {
        public Guid UserSettingsId { get; set; }

        public Guid ElementId { get; set; }

        /// <summary>
        /// Пользователь настройки
        /// </summary>
        public Guid ClientProfileId { get; set; }

        /// <summary>
        /// Значение настройки
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int DisplayOrder { get; set; }

        public virtual Element Element { get; set; }

        public virtual ClientProfile ClientProfile { get; set; }
    }
}
