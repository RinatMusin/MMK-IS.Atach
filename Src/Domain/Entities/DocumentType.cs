using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип документа
    /// </summary>
    public class DocumentType
    {

        public DocumentType()
        {
            this.Documents = new List<Document>();
            this.Cards = new List<Card>();
            this.RouteTemplates = new List<RouteTemplate>();
            this.DocumentTemplates = new List<DocumentTemplate>();
            this.DictionaryPropertyDocumentTypes = new List<DictionaryPropertyDocumentType>();
        }

        /// <summary>
        /// Id типа документа
        /// </summary>
        public Guid DocumentTypeId { get; set; }

        /// <summary>
        /// Id родительского типа документа
        /// </summary>
        public Guid? ParentDocumentTypeId { get; set; }
        /// <summary>
        /// Идентификатор позиции надпечатки 
        /// </summary>
        public Guid? StampPositionId { get; set; }

        /// <summary>
        /// Название типа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Имя сиквенса 
        /// </summary>
        public string SequenceName { get; set; }

        /// <summary>
        /// Маска регистрационного номера
        /// </summary>
        public string RegistrationNumberTemplate { get; set; }

        /// <summary>
        /// Идентификатр отдела
        /// </summary>
        public Guid? DepartmentId { get; set; }

        /// <summary>
        /// Приоритет для создания поумолчанию 
        /// </summary>
        public int CreationPriority { get; set; }

        /// <summary>
        /// сортировка default = 0
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Признак вставки QR кода в шаблон default = false 
        /// </summary>
        public bool IsInsertQRCode { get; set; }

        /// <summary>
        /// Признак обновления регистрационного номера 
        /// </summary>
        public bool IsReplaceRegNumber { get; set; }
        /// <summary>
        ///  родительский типа документа
        /// </summary>
        public virtual DocumentType ParentDocumentType { get; set; }

        /// <summary>
        /// Отдел
        /// </summary>
        public virtual Department Department { get; set; }


        public virtual StampPosition StampPosition { get; set; }

        /// <summary> 
        /// Документы
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

        /// <summary>
        /// Карты 
        /// </summary>
        public virtual ICollection<Card> Cards { get; set; }

        /// <summary>
        /// Возможные действия поручения
        /// </summary>
        public virtual ICollection<DocumentTypeActivity> DocumentTypeActivities { get; set; }

        /// <summary>
        /// Шаблоны маршрутов 
        /// </summary>
        public virtual ICollection<RouteTemplate> RouteTemplates { get; set; }

        /// <summary>
        /// Шаблоны для документа 
        /// </summary>
        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }

        /// <summary>
        /// Сопоставление роли с типами документа 
        /// </summary>
        public virtual ICollection<DocumentTypeRole> DocumentTypeRoles { get; set; }

        public virtual ICollection<DictionaryPropertyDocumentType> DictionaryPropertyDocumentTypes { get; set; }
    }
}
