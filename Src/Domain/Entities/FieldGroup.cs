using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    ///  Группа поля взято из xxint_engine_groups
    /// </summary>
    public class FieldGroup : BaseModel
    {
        public FieldGroup()
        {
            CardFields = new List<CardField>();
        }
        /// <summary>
        /// Id группы полей
        /// </summary>
        public Guid FieldGroupId { get; set; }

        /// <summary>
        /// Id родительской группы полей
        /// </summary>
        public Guid? ParentFieldGroupId { get; set; }

        /// <summary>
        /// Название 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Родительская группа полей
        /// </summary>
        public virtual FieldGroup ParentFieldGroup { get; set; }

        /// <summary>
        /// Поля
        /// </summary>
        public virtual ICollection<CardField> CardFields { get; set; }

    }
}
