using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// тип поля действия маршрута
    /// </summary>
    public class RouteActionFieldType
    {
        public RouteActionFieldType()
        {
            this.RouteActionFields = new List<RouteActionField>();
        }
        public Guid RouteActionFieldTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RouteActionField> RouteActionFields { get; set; }
    }
}
