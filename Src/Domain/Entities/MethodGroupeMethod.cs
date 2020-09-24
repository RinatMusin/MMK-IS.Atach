using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class MethodGroupeMethod
    {
        public Guid MethodGroupeMethodId { get; set; }
        public Guid RouteMethodId { get; set; }
        public Guid MethodGroupeId { get; set; }

        public virtual RouteMethod RouteMethod { get; set; }

        public virtual MethodGroupe MethodGroupe { get; set; }

    }
}
