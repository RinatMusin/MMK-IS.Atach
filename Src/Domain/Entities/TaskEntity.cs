using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Поручение
    /// </summary>
    public class TaskEntity : BaseModel
    {
        public TaskEntity()
        {
            this.RouteSteps = new List<RouteStep>();
            this.TaskHistories = new List<TaskHistory>();
            this.ChatMessagesQnt = new List<ChatMessagesQnt>();
        }

        /// <summary>
        /// Id поручения
        /// </summary>
        public Guid TaskId { get; set; }

        /// <summary>
        /// Id документа
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Id родителя поручения
        /// </summary>
        public Guid? ParentTaskId { get; set; }

        /// <summary>
        /// Id рабочего места, служит для доступа к поручению
        /// </summary>
        public Guid WorkplaceId { get; set; }

        /// <summary>
        /// Id статуса поручения
        /// </summary>
        public Guid TaskStatusId { get; set; }

        /// <summary>
        /// Id типа поручения
        /// </summary>
        public Guid TaskTypeId { get; set; }

        /// <summary>
        /// Id ползьзователя создавший таск
        /// </summary>
        public Guid FromUserId { get; set; }

        /// <summary>
        /// Id ползьзователя кому назначен таск
        /// </summary>
        public Guid ToUserId { get; set; }

        /// <summary>
        /// Id замещаемоево пользвоателя 
        /// </summary>
        public Guid? ReplacementUserId { get; set; }

        /// <summary>
        /// Id карты
        /// </summary>
        public Guid? CardId { get; set; }
        /// <summary>
        /// Резолюция
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// Признак на контроле 
        /// </summary>
        public bool IsControl { get; set; }

        /// <summary>
        /// признак показа красного глаза 
        /// </summary>
        public bool IsShowRedEye { get; set; }

        /// <summary>
        /// Признак нового поручения
        /// </summary>
        public bool IsNewTask { get; set; }

        /// <summary>
        /// Признак видимости 
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Дата выполнения поручения
        /// </summary>
        public DateTime? CompleteDate { get; set; }

        /// <summary>
        /// Установленная дата поручения(Когда должно выполниться )
        /// </summary>
        public DateTime? DateOfExecution { get; set; }

        /// <summary>
        /// Родительское поручение 
        /// </summary>
        public virtual TaskEntity ParentTask { get; set; }

        /// <summary>
        /// Рабочее место, служит для доступа к поручению
        /// </summary>
        public virtual Workplace Workplace { get; set; }

        /// <summary>
        /// Статус поручения
        /// </summary>
        public virtual TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Тип поручения
        /// </summary>
        public virtual TaskType TaskType { get; set; }

        /// <summary>
        /// Пользователь создавший поручение
        /// </summary>
        public virtual ClientProfile FromUser { get; set; }

        /// <summary>
        /// Пользователь кому назначено поручение
        /// </summary>
        public virtual ClientProfile ToUser { get; set; }


        /// <summary>
        /// Замещающий пользователь 
        /// </summary>
        public virtual ClientProfile ReplacementUser { get; set; }
        /// <summary>
        /// Документ
        /// </summary>
        public virtual Document Document { get; set; }

        /// <summary>
        /// Карта полей
        /// </summary>
        public virtual Card Card { get; set; }

        /// <summary>
        /// Шаг маршрута 
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// История поручений 
        /// </summary>
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }

        /// <summary>
        /// Счетчик сообщений
        /// </summary>
        public virtual ICollection<ChatMessagesQnt> ChatMessagesQnt { get; set; }

        public IEnumerable<ClientProfile> GetUsers()
        {
            if (ToUserId != null)
            {
                yield return ToUser;
            }
            else
            {
                if (Workplace != null)
                {
                    var users = Workplace.WorkplaceUsers;
                    foreach (var user in users)
                    {
                        yield return user.User;
                    }
                }
            }
        }
    }
}
