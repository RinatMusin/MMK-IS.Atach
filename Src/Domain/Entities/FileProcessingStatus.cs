using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Статус обработки файла
    /// </summary>
    public class FileProcessingStatus
    {
        public FileProcessingStatus()
        {
            this.Attachments = new HashSet<DocumentAttachment>();
        }

        /// <summary>
        /// Id статуса
        /// </summary>
        public Guid StatusId { get; set; }

        /// <summary>
        /// Название статуса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Признак указывающий конечный это или промежуточный статус
        /// </summary>
        public bool IsTerminal { get; set; }

        /// <summary>
        /// Вложения
        /// </summary>
        public virtual ICollection<DocumentAttachment> Attachments { get; set; }
    }


}
