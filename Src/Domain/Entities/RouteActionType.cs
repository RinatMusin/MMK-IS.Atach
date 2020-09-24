using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteActionType
    {
        /// <summary>
        /// тип действия
        /// </summary>
        public RouteActionType()
        {
            this.RouteActions = new HashSet<RouteAction>();
        }
        public Guid RouteActionTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RouteAction> RouteActions { get; set; }
    }
}
