using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteMethod
    {
        /// <summary>
        /// метод маршрута
        /// </summary>
        public RouteMethod()
        {
            this.RouteActionFieldMethods = new List<RouteActionFieldMethod>();
            this.MethodGroupeMethods = new List<MethodGroupeMethod>();
        }
        public Guid RouteMethodId { get; set; }
        public string Name { get; set; }

        public ICollection<RouteActionFieldMethod> RouteActionFieldMethods { get; set; }
        public ICollection<MethodGroupeMethod> MethodGroupeMethods { get; set; }
    }
}
