using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class Route
    {
        public Route()
        {
            this.RouteSteps = new List<RouteStep>();
        }

        /// <summary>
        /// Id маршрута
        /// </summary>
        public Guid RouteId { get; set; }

        /// <summary>
        /// Id документа за которымс закреплен шаблон 
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Имя шаблона
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Версия маршрута
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Группы шагов маршрута
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// Документа
        /// </summary>
        public virtual Document Document { get; set; }

    }
}
