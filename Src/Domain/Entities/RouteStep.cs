using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Шаг маршрута
    /// </summary>
    public class RouteStep
    {
        public RouteStep()
        {
            RouteStepProperties = new List<RouteStepProperty>();
        }

        /// <summary>
        /// Id шага маршрута
        /// </summary>
        public Guid RouteStepId { get; set; }

        /// <summary>
        /// Id группы шагов маршрута
        /// </summary>
        public Guid RouteStepGroupId { get; set; }

        /// <summary>
        /// Id маршрута
        /// </summary>
        public Guid RouteId { get; set; }

        /// <summary>
        /// Id шаблона для шага
        /// </summary>
        public Guid? RouteStepTemplateId { get; set; }


        /// <summary>
        /// Порядок отображения
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Порядок парралельных шагов
        /// </summary>
        public int? ParallelOrder { get; set; }

        /// <summary>
        /// Порядок для групировки шагов
        /// </summary>
        public int? GroupOrder { get; set; }

        /// <summary>
        /// Id типа шага
        /// </summary>
        public Guid StepTypeId { get; set; }

        /// <summary>
        /// тип измененийц
        /// </summary>
        public Guid? TargetTypeId { get; set; }

        /// <summary>
        /// Признак возможности редактированитя  шага
        /// </summary>
        public bool IsEditable { get; set; }

        /// <summary>
        /// Признак обязательности шага
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Признак прйденности шага
        /// </summary>
        public bool IsPassed { get; set; }


        /// <summary>
        /// Видимость шаг
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid? GroupId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime PlannedDate { get; set; }

        public int? Duration { get; set; }

        /// <summary>
        /// Id действия маршрута 
        /// </summary>
        public Guid? RouteActionId { get; set; }

        /// <summary>
        /// Id Поручения
        /// </summary>
        public Guid? TaskId { get; set; }


        public Guid? AfterSendCardId { get; set; }

        public Guid? BeforeCardId { get; set; }

        /// <summary>
        /// Идентификатор файла замечания на шаге
        /// </summary>
        public Guid? NoteFileId { get; set; }

        /// <summary>
        /// Был отозван 
        /// </summary>
        public bool WasRecalled { get; set; }
        /// <summary>
        /// Список всех замечаний на шаге
        /// </summary>
        public virtual ICollection<RouteStepNote> RouteStepNotes { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        public virtual Route Route { get; set; }

        /// <summary>
        /// Группа шагов маршрута
        /// </summary>
        public virtual RouteStepGroup RouteStepGroup { get; set; }

        /// <summary>
        /// Пользовател
        /// </summary>
        public virtual ClientProfile User { get; set; }

        /// <summary>
        /// Пользовател
        /// </summary>
        public virtual Group Group { get; set; }

        /// <summary>
        /// Карточка
        /// </summary>
        public virtual Card BeforeCard { get; set; }

        /// <summary>
        /// Карточка после отправления
        /// </summary>
        public virtual Card AfterSendCard { get; set; }

        /// <summary>
        /// Поручение
        /// </summary>
        public virtual TaskEntity TaskEntity { get; set; }

        /// <summary>
        /// Действие маршрута
        /// </summary>
        public virtual RouteAction RouteAction { get; set; }

        /// <summary>
        /// Тип шага маршрута
        /// </summary>
        public virtual RouteStepType RouteStepType { get; set; }

        /// <summary>
        /// изменения
        /// </summary>
        public virtual FieldTargetType TargetType { get; set; }

        public virtual File File { get; set; }

        /// <summary>
        /// Список свойств для шага
        /// </summary>
        public virtual ICollection<RouteStepProperty> RouteStepProperties { get; set; }
        public virtual RouteStepTemplate RouteStepTemplate { get; set; }
    }
}
