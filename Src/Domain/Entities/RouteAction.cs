using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteAction
    {
        /// <summary>
        /// маршрут действия
        /// </summary>
        public RouteAction()
        {
            this.RouteStepTemplates = new List<RouteStepTemplate>();
            this.ActionFields = new List<RouteActionField>();
            this.RouteSteps = new List<RouteStep>();
            this.OutRouteStepGroups = new List<RouteStepGroup>();
            this.InRouteStepGroups = new List<RouteStepGroup>();
        }
        public Guid RouteActionId { get; set; }
        public Guid RouteActionTypeId { get; set; }
        public string Name { get; set; }

        public virtual RouteActionType RouteActionType { get; set; }
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }
        public virtual ICollection<RouteActionField> ActionFields { get; set; }
        public virtual ICollection<RouteStep> RouteSteps { get; set; }
        public virtual ICollection<RouteStepGroup> InRouteStepGroups { get; set; }
        public virtual ICollection<RouteStepGroup> OutRouteStepGroups { get; set; }

    }
}
