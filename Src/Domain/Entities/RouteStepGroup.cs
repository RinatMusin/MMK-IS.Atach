using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Группа шагов маршрута
    /// </summary>
    public class RouteStepGroup
    {
        public RouteStepGroup()
        {
            this.RouteSteps = new List<RouteStep>();
            this.RouteStepTemplates = new List<RouteStepTemplate>();
        }
        /// <summary>
        /// Id группы шагов маршрута
        /// </summary>
        public Guid RouteStepGroupId { get; set; }

        /// <summary>
        /// Id карты полей для показа полсе отправки
        /// </summary>
        public Guid AfterSendCardId { get; set; }

        /// <summary>
        /// Id карты полей для показа на шаге
        /// </summary>
        public Guid CardId { get; set; }

        /// <summary>
        /// Тип шага по умолчанию
        /// </summary>
        public Guid RouteStepTypeId { get; set; }

        /// <summary>
        /// Статус документа при входе в группу 
        /// </summary>
        public Guid? DocumentStatusId { get; set; }

        //TODO What is this?
        /// <summary>
        /// Действие при выходе из группы
        /// </summary>
        public Guid? RouteActionId { get; set; }

        //TODO What is this?
        /// <summary>
        /// Действие при выходе из группы
        /// </summary>
        public Guid? OnInMethodGroupId { get; set; }

        //TODO Remove
        /// <summary>
        /// Действие при выходе из группы
        /// </summary>
        public Guid? OnOutMethodGroupId { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Заплонированное выполнение шага в днях
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Обязательность шага
        /// </summary>
        public bool IsStepRequired { get; set; }

        /// <summary>
        /// Возможность добавить паралельные шаги
        /// </summary>
        public bool IsParallelEditable { get; set; }

        /// <summary>
        /// Создавать группу в новых версиях маршрута 
        /// </summary>
        public bool IsCreateInNewVersion { get; set; }

        /// <summary>
        /// Какую карту показывать на шаге
        /// </summary>
        public virtual Card Card { get; set; }

        public virtual DocumentStatus DocumentStatus { get; set; }
        /// <summary>
        /// Какую карту показывать полсе отправки
        /// </summary>
        public virtual Card AfterSendCard { get; set; }

        /// <summary>
        /// Действия над шагом при выходе 
        /// </summary>
        public virtual RouteAction RouteAction { get; set; }

        /// <summary>
        /// Действия при входе в шаг
        /// </summary>
        public virtual MethodGroupe OnInMethodGroup { get; set; }
        /// <summary>
        /// Действия при выходе с шага
        /// </summary>
        public virtual MethodGroupe OnOutMethodGroup { get; set; }

        /// <summary>
        /// Тип шага по умолчанию
        /// </summary>
        public virtual RouteStepType RouteStepType { get; set; }

        /// <summary>
        /// Шаги группы шагов маршрута
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// шаблоны шагов маршрута
        /// </summary>
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }
    }
}
