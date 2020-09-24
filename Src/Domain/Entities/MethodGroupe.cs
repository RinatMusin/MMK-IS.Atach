using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// методы на группе
    /// </summary>
    public class MethodGroupe
    {
        public MethodGroupe()
        {
            this.MethodGroupeMethods = new List<MethodGroupeMethod>();
            this.RouteStepTypesIn = new List<RouteStepType>();
            this.RouteStepTypesOut = new List<RouteStepType>();
            this.RouteStepTypesReject = new List<RouteStepType>();
            this.RouteStepGroupsIn = new List<RouteStepGroup>();
            this.RouteStepGroupsOut = new List<RouteStepGroup>();
        }

        public Guid MethodGroupeId { get; set; }

        public virtual ICollection<MethodGroupeMethod> MethodGroupeMethods { get; set; }

        public virtual ICollection<RouteStepType> RouteStepTypesIn { get; set; }
        public virtual ICollection<RouteStepType> RouteStepTypesOut { get; set; }
        public virtual ICollection<RouteStepType> RouteStepTypesReject { get; set; }
        public virtual ICollection<RouteStepGroup> RouteStepGroupsIn { get; set; }
        public virtual ICollection<RouteStepGroup> RouteStepGroupsOut { get; set; }
    }
}
