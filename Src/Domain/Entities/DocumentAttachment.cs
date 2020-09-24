using System;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Пложения в документе 
    /// </summary>
    public class DocumentAttachment
    {
        public DocumentAttachment() { }

        /// <summary>
        /// Конструктор делающий копию
        /// </summary>
        /// <param name="attachment"></param>
        public DocumentAttachment(DocumentAttachment attachment)
        {
            this.DocumentAttachmentId = attachment.DocumentAttachmentId;
            this.DocumentId = attachment.DocumentId;
            this.FileId = attachment.FileId;
            this.IsFromTemplate = attachment.IsFromTemplate;
            this.IsMainFile = attachment.IsMainFile;
            this.ProcessingStatusId = attachment.ProcessingStatusId;
        }
        /// <summary>
        /// Id вложениия 
        /// </summary>
        public Guid DocumentAttachmentId { get; set; }

        /// <summary>
        /// Id Документа
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Id файла
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        /// Id статуса обработки файла
        /// </summary>
        public Guid ProcessingStatusId { get; set; }

        /// <summary>
        /// Признак основгого документа
        /// </summary>
        public bool IsMainFile { get; set; }

        /// <summary>
        /// Статус обработки файла
        /// </summary>
        public virtual FileProcessingStatus ProcessingStatus { get; set; }

        /// <summary>
        /// Создан из шаблона
        /// </summary>
        public bool IsFromTemplate { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public virtual Document Document { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public virtual File File { get; set; }
    }
}
