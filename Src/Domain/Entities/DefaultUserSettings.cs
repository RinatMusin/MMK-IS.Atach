using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Пользовательские настройки по умолчанию, если пользователь ничего не выбрал
    /// </summary>
    public class DefaultUserSettings
    {
        public Guid DefaultUserSettingsId { get; set; }

        public Guid ElementId { get; set; }

        /// <summary>
        /// Значение настройки
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int DisplayOrder { get; set; }

        public virtual Element Element { get; set; }
    }
}
