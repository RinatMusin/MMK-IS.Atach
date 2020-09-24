using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Поля
    /// </summary>
    public class Field
    {
        public Field()
        {
            this.CardFields = new List<CardField>();
            this.FieldProperties = new List<FieldProperty>();
            this.MainFields = new List<FieldDependency>();
            this.FieldCounterParties = new List<FieldCounterPartyType>();
        }

        /// <summary>
        /// Id Поля
        /// </summary>
        public Guid FieldId { get; set; }

        /// <summary>
        /// Id типа поля
        /// </summary>
        public Guid FieldTypeId { get; set; }

        /// <summary>
        /// Id место назначения
        /// </summary>
        public Guid TargetTypeId { get; set; }

        /// <summary>
        /// Название поля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Системное имя
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Адрес взятия данных для сложных типов
        /// </summary>
        public string DataUrl { get; set; }

        /// <summary>
        /// Маска поля
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// Значение по умолчанию
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Тип родительского поля
        /// </summary>
        public virtual FieldType FieldType { get; set; }

        /// <summary>
        /// Тип назначения поля 
        /// </summary>
        public virtual FieldTargetType FieldTargetType { get; set; }

        /// <summary>
        /// Поля карточки
        /// </summary>
        public virtual ICollection<CardField> CardFields { get; set; }

        /// <summary>
        /// Свойства поля
        /// </summary>
        public virtual ICollection<FieldProperty> FieldProperties { get; set; }

        /// <summary>
        /// Основоное поле  для постройки урла
        /// </summary>
        public virtual ICollection<FieldDependency> MainFields { get; set; }

        /// <summary>
        /// Зависящие поля 
        /// </summary>
        public virtual ICollection<FieldDependency> DependencyFields { get; set; }

        /// <summary>
        /// поля контрагента
        /// </summary>
        public virtual ICollection<FieldCounterPartyType> FieldCounterParties { get; set; }


    }
}
