using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Поле действия маршрута
    /// </summary>
    public class RouteActionField
    {
        public RouteActionField()
        {
            this.RouteActionFieldMethods = new List<RouteActionFieldMethod>();
        }
        /// <summary>
        /// Id поля действия
        /// </summary>
        public Guid ActionFieldId { get; set; }

        /// <summary>
        /// Id действия
        /// </summary>
        public Guid RouteActionId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        public Guid? ParentFieldId { get; set; }

        public Guid RouteActionFieldTypeId { get; set; }

        /// <summary>
        /// Цвет компонета 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Тип поля
        /// </summary>
        public virtual RouteActionFieldType RouteActionFieldType { get; set; }

        /// <summary>
        /// Действие маршрута
        /// </summary>
        public virtual RouteAction RouteAction { get; set; }

        public virtual ICollection<RouteActionFieldMethod> RouteActionFieldMethods { get; set; }
    }
}
