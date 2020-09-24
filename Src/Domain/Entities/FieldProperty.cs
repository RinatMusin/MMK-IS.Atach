using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// свойства полей
    /// </summary>
    public class FieldProperty
    {
        public Guid FieldPropertyId { get; set; }
        public Guid FieldId { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }

        public virtual Field Field { get; set; }

    }
}
