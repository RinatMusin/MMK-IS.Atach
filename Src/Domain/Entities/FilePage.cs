using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Страница файла
    /// </summary>
    public class FilePage
    {
        /// <summary>
        /// Id страницы
        /// </summary>
        public Guid FilePageId { get; set; }

        /// <summary>
        /// Id файла 
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        /// Изображение страницы
        /// </summary>
        public byte[] PageImage { get; set; }

        /// <summary>
        /// Номер страницы
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Дата встаки
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        public virtual File File { get; set; }
    }
}
