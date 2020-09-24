using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteStepNote
    {
        /// <summary>
        /// Идентификатор записи замечания на шаге
        /// </summary>
        public Guid RouteStepNoteId { get; set; }

        /// <summary>
        /// Идентификатор шага на маршруте
        /// </summary>
        public Guid RouteStepId { get; set; }

        /// <summary>
        /// Идентификатор замечания из словаря замечаний
        /// </summary>
        public Guid NoteId { get; set; }

        /// <summary>
        /// Словарь замечаний
        /// </summary>
        public virtual DictionarySendingForRevision SendingForRevision { get; set; }

        /// <summary>
        /// Шаг на маршруте
        /// </summary>
        public virtual RouteStep RouteStep { get; set; }
    }
}
