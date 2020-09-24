using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип шага маршрута
    /// </summary>
    public class RouteStepType
    {
        public RouteStepType()
        {
            this.RouteSteps = new List<RouteStep>();
            this.RouteStepGroups = new List<RouteStepGroup>();
            this.RouteStepTemplates = new List<RouteStepTemplate>();
        }
        /// <summary>
        /// Id типа шага маршрута
        /// </summary>
        public Guid RouteStepTypeId { get; set; }

        public Guid? OnAcceptTaskStatusId { get; set; }

        public Guid? OnRejectTaskStatusId { get; set; }

        public Guid? OnCreateTaskStatusId { get; set; }

        public Guid? OnInMethodGroupId { get; set; }
        public Guid? OnOutMethodGroupId { get; set; }
        public Guid? OnRejectMethodGroupId { get; set; }

        /// <summary>
        /// Системный тип
        /// </summary>
        public bool IsSystemType { get; set; }
        /// <summary>
        /// Статус при согласовании 
        /// </summary>
        public virtual TaskStatus OnAcceptTaskStatus { get; set; }

        /// <summary>
        /// Статус при отмене 
        /// </summary>
        public virtual TaskStatus OnRejectTaskStatus { get; set; }

        /// <summary>
        /// Статус пр создании 
        /// </summary>
        public virtual TaskStatus OnCreateTaskStatus { get; set; }

        /// <summary>
        /// Действия при входе в шаг
        /// </summary>
        public virtual MethodGroupe OnInMethodGroup { get; set; }
        /// <summary>
        /// Действия при выходе с шага
        /// </summary>
        public virtual MethodGroupe OnOutMethodGroup { get; set; }
        /// <summary>
        /// Действия при отклонении
        /// </summary>
        public virtual MethodGroupe OnRejectMethodGroup { get; set; }

        /// <summary>
        /// Название типа шага маршрута
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Шаги маршрута
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// Шаблоны шагов маршрута
        /// </summary>
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }

        /// <summary>
        /// Группы шагов маршрута
        /// </summary>
        public virtual ICollection<RouteStepGroup> RouteStepGroups { get; set; }
    }
}
