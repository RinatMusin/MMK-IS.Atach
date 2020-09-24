using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class FileType
    {
        public FileType()
        {
            this.Files = new List<File>();
        }
        public Guid FileTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
