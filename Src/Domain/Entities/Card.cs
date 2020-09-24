using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Карточки поручений взято с таблицы xxint_engine_cards
    /// </summary>
    public class Card
    {
        public Card()
        {
            this.CardFields = new List<CardField>();
            this.Tasks = new List<TaskEntity>();
            this.RouteSteps = new List<RouteStep>();
            this.AfterSendRouteSteps = new List<RouteStep>();
            this.RouteStepGroups = new List<RouteStepGroup>();
            this.AfterRouteStepGroups = new List<RouteStepGroup>();
        }

        /// <summary>
        /// Id карты 
        /// </summary>
        public Guid CardId { get; set; }

        /// <summary>
        /// Id Родительской карты
        /// </summary>
        public Guid? ParentCardId { get; set; }

        /// <summary>
        /// Ид типа докумета
        /// </summary>
        public Guid DocumentTypeId { get; set; }

        /// <summary>
        /// Имя карты 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание карты 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Признак шаблона карты  
        /// </summary>
        public bool IsTemplate { get; set; }

        /// <summary>
        /// Родительская карта
        /// </summary>
        public virtual Card ParentCard { get; set; }

        /// <summary>
        /// Тип документа 
        /// </summary>
        public virtual DocumentType DocumentType { get; set; }

        /// <summary>
        /// Атрибуты карты 
        /// </summary>
        public virtual ICollection<CardField> CardFields { get; set; }

        /// <summary>
        /// Поручения
        /// </summary>
        public virtual ICollection<TaskEntity> Tasks { get; set; }


        /// <summary>
        /// Шаги маршрутов
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// Шаги маршрутов
        /// </summary>
        public virtual ICollection<RouteStep> AfterSendRouteSteps { get; set; }


        /// <summary>
        ///  Шаги группы маршрутов
        /// </summary>
        public virtual ICollection<RouteStepGroup> RouteStepGroups { get; set; }

        /// <summary>
        /// Шаги группы маршрутов полсе отправки
        /// </summary>
        public virtual ICollection<RouteStepGroup> AfterRouteStepGroups { get; set; }

    }
}
