using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class Document
    {
        /// <summary>
        /// Документ область для создания поручений
        /// </summary>
        public Document()
        {
            this.DocumentAttachments = new List<DocumentAttachment>();
            this.Tasks = new List<TaskEntity>();
            this.DocumentFieldValues = new List<DocumentFieldValue>();
            this.Routes = new List<Route>();
            this.Chats = new List<Chat>();
        }

        /// <summary>
        /// Id документа
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Id основого документа
        /// </summary>
        public Guid? ParentDocumentId { get; set; }

        /// <summary>
        /// Id типа документа
        /// </summary>
        public Guid DocumentTypeId { get; set; }

        /// <summary>
        /// Id статуса документа
        /// </summary>
        public Guid DocumentStatusId { get; set; }

        /// <summary>
        /// Название документа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание документа
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Ключивые слова для поиска документов
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Ключивые слова для поиска документов устарели
        /// </summary>
        public bool KeywordsOutdated { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        public string Counterparty { get; set; }

        /// <summary>
        /// Пользователь создавший докумет 
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Признак документ создан для ознакомления 
        /// </summary>
        public bool IsForReview { get; set; }

        /// <summary>
        /// Признак документ создан для поручений на маршруте 
        /// </summary>
        public bool IsForTask { get; set; }

        /// <summary>
        /// Признак документ создан для замещения 
        /// </summary>
        public bool IsForReplacement { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public virtual DocumentType DocumentType { get; set; }

        /// <summary>
        /// Статус документа
        /// </summary>
        public virtual DocumentStatus DocumentStatus { get; set; }

        /// <summary>
        /// Основной документ 
        /// </summary>
        public virtual Document ParentDocument { get; set; }

        public virtual ClientProfile CreationUser { get; set; }
        /// <summary>
        /// Вложения документа
        /// </summary>
        public virtual ICollection<DocumentAttachment> DocumentAttachments { get; set; }

        /// <summary>
        /// Поручения
        /// </summary>
        public virtual ICollection<TaskEntity> Tasks { get; set; }

        /// <summary>
        /// Атрибуты документа
        /// </summary>
        public virtual ICollection<DocumentFieldValue> DocumentFieldValues { get; set; }

        /// <summary>
        /// Маршруты 
        /// </summary>
        public virtual ICollection<Route> Routes { get; set; }

        /// <summary>
        /// чатs
        /// </summary>
        public virtual ICollection<Chat> Chats { get; set; }

        public object DocumnetTypeName { get; set; }
    }
}
