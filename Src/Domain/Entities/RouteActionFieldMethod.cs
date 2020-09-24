using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// метод поля действия маршрута
    /// </summary>
    public class RouteActionFieldMethod
    {
        public Guid RouteActionFieldMethodId { get; set; }
        public Guid RouteActionFieldId { get; set; }
        public Guid RouteMethodId { get; set; }

        public virtual RouteActionField RouteActionField { get; set; }
        public virtual RouteMethod RouteMethod { get; set; }
    }
}
