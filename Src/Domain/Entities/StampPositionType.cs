using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Типы надпечаток
    /// </summary>
    public class StampPositionType
    {
        public Guid StampPositionTypeId { get; set; }
        /// <summary>
        /// Тип надпечатки
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Текст надпечатки
        /// </summary>
        public string Text { get; set; }
        public virtual ICollection<StampPosition> StampPositions { get; set; }
    }
}
