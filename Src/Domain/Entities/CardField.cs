using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Поля в карточке
    /// </summary>
    public class CardField
    {
        public CardField()
        {
            this.DocumentFieldValues = new List<DocumentFieldValue>();
            this.CardFieldTempates = new List<CardFieldTempate>();
            this.CardFieldDefaultValues = new List<CardFieldDefaultValue>();
        }

        /// <summary>
        /// Id поля карточки
        /// </summary>
        public Guid CardFieldId { get; set; }

        /// <summary>
        /// Id поля
        /// </summary>
        public Guid FieldId { get; set; }

        /// <summary>
        /// Id Группы
        /// </summary>
        public Guid? FieldGroupId { get; set; }

        /// <summary>
        /// Id карточки
        /// </summary>
        public Guid CardId { get; set; }

        /// <summary>
        /// Порядок отображения поля 
        /// </summary>
        public int DisplayOrder { get; set; }
        /// <summary>
        /// Признак возможности редактирования
        /// </summary>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Признак обязательности 
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Признак множествастрок
        /// </summary>
        public bool IsMultirow { get; set; }

        /// <summary>
        /// Признак видимости
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Карточка
        /// </summary>
        public virtual Card Card { get; set; }

        /// <summary>
        /// Поле
        /// </summary>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Группа полей
        /// </summary>
        public virtual FieldGroup FieldGroup { get; set; }

        /// <summary>
        /// Данные для поля 
        /// </summary>
        public string DataUrl { get; set; }

        /// <summary>
        /// Атрибуты документа
        /// </summary>
        public virtual ICollection<DocumentFieldValue> DocumentFieldValues { get; set; }

        /// <summary>
        /// Поля для шаблонов
        /// </summary>
        public virtual ICollection<CardFieldTempate> CardFieldTempates { get; set; }

        /// <summary>
        /// Значения поля по умолчанию 
        /// </summary>
        public virtual ICollection<CardFieldDefaultValue> CardFieldDefaultValues { get; set; }
    }
}
