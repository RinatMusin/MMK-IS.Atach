using System;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Атрибуты документа
    /// </summary>
    public class DocumentFieldValue
    {
        /// <summary>
        /// Id атрибута документа
        /// </summary>
        public Guid DocumentFieldValueId { get; set; }

        /// <summary>
        /// Id полей карточки
        /// </summary>
        public Guid CardFieldId { get; set; }

        /// <summary>
        /// Id Документа 
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Значение поля 
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Сериализованное значение, по которому строится поисковый индекс
        /// </summary>
        public string SearchableValue { get; set; }

        /// <summary>
        /// Поля карточки
        /// </summary>
        public virtual CardField CardField { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public virtual Document Document { get; set; }


    }

}

