using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип поля для записи данных
    /// </summary>
    public class FieldTargetType
    {
        public FieldTargetType()
        {
            this.Fields = new List<Field>();
        }

        /// <summary>
        /// Id типа поля для записи данных
        /// </summary>
        public Guid FieldTargetTypeId { get; set; }

        /// <summary>
        /// Название типа поля для записи данных
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Поля
        /// </summary>
        public virtual ICollection<Field> Fields { get; set; }


        public virtual ICollection<RouteStep> RouteSteps { get; set; }
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }
    }
}
