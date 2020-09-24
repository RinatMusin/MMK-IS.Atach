using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class Department
    {
        /// <summary>
        /// раздел
        /// </summary>
        public Department()
        {
            this.DocumentTypes = new List<DocumentType>();
        }
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
    }
}
