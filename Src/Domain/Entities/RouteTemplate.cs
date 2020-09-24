using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Шаблон маршрута
    /// </summary>
    public class RouteTemplate
    {
        public RouteTemplate()
        {
            this.RouteStepTemplates = new List<RouteStepTemplate>();
            this.Routes = new List<Route>();
        }

        /// <summary>
        /// Id шаблона маршрута
        /// </summary>
        public Guid RouteTemplateId { get; set; }

        /// <summary>
        /// Id типа документа
        /// </summary>
        public Guid DocumentTypeId { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        public virtual DocumentType DocumentType { get; set; }

        /// <summary>
        /// Шаблоны шагов маршрута
        /// </summary>
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }

        /// <summary>
        /// Маршруты
        /// </summary>
        public virtual ICollection<Route> Routes { get; set; }
    }
}
