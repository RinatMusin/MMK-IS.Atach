using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Позиции надпечатки 
    /// </summary>
    public class StampPosition
    {
        public Guid StampPositionId { get; set; }
        /// <summary>
        /// Тип надпечатки
        /// </summary>
        public Guid StampPositionTypeId { get; set; }
        public string Position { get; set; }
        /// <summary>
        /// Устанавливает величину отступа от нижнего края элемента.
        /// </summary>
        public int MarginBottom { get; set; }
        /// <summary>
        /// Устанавливает величину отступа от левого края элемента.
        /// </summary>
        public int MarginLeft { get; set; }
        /// <summary>
        /// Устанавливает величину отступа от правого края элемента.
        /// </summary>
        public int MarginRight { get; set; }
        /// <summary>
        /// Устанавливает величину отступа от верхнего края элемента.
        /// </summary>
        public int MarginTop { get; set; }
        /// <summary>
        /// Признак по умолчанию 
        /// </summary>
        public bool IsDefault { get; set; }

        public virtual StampPositionType StampPositionType { get; set; }
        /// <summary>
        /// Типы документов
        /// </summary>
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }

    }
}
