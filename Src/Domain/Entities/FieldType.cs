using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип поля
    /// </summary>
    public class FieldType
    {
        public FieldType()
        {
            Fields = new List<Field>();
        }
        /// <summary>
        /// Id типа поля
        /// </summary>
        public Guid FieldTypeId { get; set; }
        
        /// <summary>
        /// Название типа поля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Поля 
        /// </summary>
        public virtual ICollection<Field> Fields { get; set; }
    }
}
