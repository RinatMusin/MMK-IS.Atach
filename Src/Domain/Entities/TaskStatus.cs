using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Статус поручения
    /// </summary>
    public class TaskStatus
    {
        public TaskStatus()
        {
            this.TaskEntities = new HashSet<TaskEntity>();
            this.OnAcceptRouteStepTypes = new HashSet<RouteStepType>();
            this.OnRejectRouteStepTypes = new HashSet<RouteStepType>();
            this.OnCreateRouteStepTypes = new HashSet<RouteStepType>();
            this.TaskStatusActivities = new HashSet<TaskStatusActivity>();
        }

        /// <summary>
        /// Id статуса поручения
        /// </summary>
        public Guid TaskStatusId { get; set; }

        /// <summary>
        /// Id типа статуса
        /// </summary>
        public Guid StatusTypeId { get; set; }

        /// <summary>
        /// Название статуса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип группы цвета статуса 
        /// </summary>
        public string StatusColor { get; set; }

        /// <summary>
        /// Тип центральной панели
        /// </summary>
        public string CenterPanelType { get; set; }

        /// <summary>
        /// Тип правой панели
        /// </summary>
        public string RightPanelType { get; set; }

        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Тип статуса
        /// </summary>
        public virtual TaskStatusType TaskStatusType { get; set; }

        /// <summary>
        /// Поручения
        /// </summary>
        public virtual ICollection<TaskEntity> TaskEntities { get; set; }


        public virtual ICollection<RouteStepType> OnAcceptRouteStepTypes { get; set; }

        public virtual ICollection<RouteStepType> OnRejectRouteStepTypes { get; set; }

        public virtual ICollection<RouteStepType> OnCreateRouteStepTypes { get; set; }

        public virtual ICollection<TaskStatusActivity> TaskStatusActivities { get; set; }

    }

}
