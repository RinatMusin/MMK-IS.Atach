using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Шаблон шага
    /// </summary>
    public class RouteStepTemplate
    {
        public RouteStepTemplate()
        {
            RouteSteps = new List<RouteStep>();
            RouteStepTemplateProperties = new List<RouteStepTemplateProperty>();
        }
        /// <summary>
        /// Id
        /// </summary>
        public Guid RouteStepTemplateId { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public Guid RouteTemplateId { get; set; }

        /// <summary>
        /// Id типа шага
        /// </summary>
        public Guid RouteStepTypeId { get; set; }

        //public Guid? BeforeCardId { get; set; }
        //public Guid? AfterCardId { get; set; }
        public Guid RouteStepGroupId { get; set; }
        /// <summary>
        /// Id Действия
        /// </summary>
        public Guid? RouteActionId { get; set; }

        /// <summary>
        /// IdПользователя
        /// </summary>
        public Guid? UserId { get; set; }

        public Guid? TargetTypeId { get; set; }

        public Guid? GroupId { get; set; }
        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Порядок парралельных шагов
        /// </summary>
        public int? ParallelOrder { get; set; }

        /// <summary>
        /// Длителность шага (в днях)
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Признак возможности редактирования
        /// </summary>
        public bool IsEditable { get; set; }

        /// <summary>
        /// Признак обязательности шага
        /// </summary>
        public bool IsRequired { get; set; }
        /// <summary>
        /// Действие маршрута
        /// </summary>
        public virtual RouteAction RouteAction { get; set; }

        /// <summary>
        /// Видимость шаг
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public virtual ClientProfile User { get; set; }

        /// <summary>
        /// Шаблон маршрута
        /// </summary>
        public virtual RouteTemplate RouteTemplate { get; set; }
        /// <summary>
        /// Группа шагов маршрута
        /// </summary>
        public virtual RouteStepGroup RouteStepGroup { get; set; }


        public virtual Group Group { get; set; }
        /// <summary>
        /// Тип шага 
        /// </summary>
        public virtual RouteStepType RouteStepType { get; set; }

        /// <summary>
        /// Шаги маршрута
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// изменения
        /// </summary>
        public virtual FieldTargetType TargetType { get; set; }
        //public virtual CardField BeforeCardField { get; set; }
        //public virtual CardField AfterCardField { get; set; }

        /// <summary>
        /// Список свойств для шага
        /// </summary>
        public virtual ICollection<RouteStepTemplateProperty> RouteStepTemplateProperties { get; set; }


    }
}
