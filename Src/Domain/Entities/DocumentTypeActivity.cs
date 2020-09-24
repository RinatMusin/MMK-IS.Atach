using System;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// вид действия документа
    /// </summary>
    public class DocumentTypeActivity
    {
        public Guid DocumentTypeActivityId { get; set; }

        public Guid ActivityId { get; set; }
        public Guid DocumentTypeId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual DocumentType DocumentType { get; set; }

    }
}
