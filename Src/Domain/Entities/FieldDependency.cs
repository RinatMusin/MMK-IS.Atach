using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// зависимости полей
    /// </summary>
    public class FieldDependency
    {
        public Guid FieldDependencyId { get; set; }
        public Guid MainFieldId { get; set; }
        public Guid DependencyFieldId { get; set; }

        public virtual Field MainField { get; set; }
        public virtual Field DependencyField { get; set; }
    }
}
