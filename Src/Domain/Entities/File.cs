using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Файл
    /// </summary>
    public class File : BaseModel, ICloneable
    {
        public File()
        {
            this.FileEdits = new List<FileEdit>();
            this.FilePages = new List<FilePage>();
            this.DocumentAttachments = new List<DocumentAttachment>();
            this.RouteSteps = new List<RouteStep>();
        }

        /// <summary>
        /// Id файла
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        /// Id пользователя загрузившего файл файл
        /// </summary>
        public Guid? UploadedUserId { get; set; }

        /// <summary>
        /// Id родительского файла
        /// </summary>
        public Guid? ParentFileId { get; set; }

        /// <summary>
        /// Id типа файла
        /// </summary>
        public Guid FileTypeId { get; set; }

        /// <summary>
        /// Место нахождения файла
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Место нахождения файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Внешний Id файна не понятно за чем
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Признак удаления файла
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Версия файла
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Дата удаления файла
        /// </summary>
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        /// Родительский файл
        /// </summary>
        public virtual File ParentFile { get; set; }

        public virtual FileType FileType { get; set; }

        public virtual ClientProfile UploadedUser { get; set; }

        /// <summary>
        /// Изменения файла
        /// </summary>
        public virtual ICollection<FileEdit> FileEdits { get; set; }

        /// <summary>
        /// Страницы файла
        /// </summary>
        public virtual ICollection<FilePage> FilePages { get; set; }

        /// <summary>
        /// Вложения
        /// </summary>
        public virtual ICollection<DocumentAttachment> DocumentAttachments { get; set; }

        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
