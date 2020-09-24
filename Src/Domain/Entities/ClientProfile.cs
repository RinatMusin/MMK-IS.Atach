using MMK_IS.Atach.Domain.Entities.Dictionary;
using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Профиль пользователя, расширяем класс ApplicationUser 
    /// </summary>
    public class ClientProfile
    {
        public ClientProfile()
        {
            WorkplacesUsers = new List<WorkplaceUser>();
            TasksFromUser = new List<TaskEntity>();
            TasksToUser = new List<TaskEntity>();
            RouteSteps = new List<RouteStep>();
            TaskHistoryCreators = new List<TaskHistory>();
            TaskHistories = new List<TaskHistory>();
            ClientProfileProperties = new List<ClientProfileProperty>();
            Documents = new List<Document>();
            ClientProfileReplacements = new List<ClientProfileReplacement>();
            ReplacementUsers = new List<ClientProfileReplacement>();
            TaskReplacementUsers = new List<TaskEntity>();
            GroupCFOs = new List<DictionaryGroupCFO>();
            Chats = new List<Chat>();
            ChatMembers = new List<ChatMember>();
            GroupCFOZGDs = new List<DictionaryGroupCFO>();
            GroupCFORiskManagers = new List<DictionaryGroupCFO>();
            DepartmentManagers = new List<DictionaryDepartmentDirectory>();
            Economists = new List<DictionaryDivizionOZM>();
            UserGroups = new List<UserGroup>();
            GroupAssigns = new List<GroupAssign>();
            UserGroupAssigns = new List<UserGroupAssign>();
        }

        /// <summary>
        /// Id профиля
        /// </summary>
        public Guid ClientProfileId { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Телефон для офиса 
        /// </summary>
        public string OfficePhone { get; set; }
        /// <summary>
        /// Аватар пользователя
        /// </summary>
        public byte[] Avatar { get; set; }

        /// <summary>
        /// Последняя подпись пользователя
        /// </summary>
        public string LastThumbprint { get; set; }

        /// <summary>
        /// Пользователь работает / уволен. Изменяется при обновлении из AD.
        /// </summary>
        public bool IsOnDuty { get; set; }

        /// <summary>
        /// Пользователь временно недоступен (отпуск, больничный). Изменяется вручную.
        /// </summary>
        public bool IsTemporarilyUnavailable { get; set; }

        /// <summary>
        /// Признак наличия доступа к облачному подписанию
        /// </summary>
        public bool? HasDSSAccess { get; set; }

        /// <summary>
        /// Переключение подписания токеном
        /// </summary>
        public bool? TokenSigningIsActive { get; set; }

        /// <summary>
        /// Личный номер сотрудника
        /// </summary>
        public string PersonalNumber { get; set; }

        public bool? DssSigningIsActive { get; set; }

        /// <summary>
        /// Пользователи
        /// </summary>
        public virtual ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// Рабочие места
        /// </summary>
        public virtual ICollection<WorkplaceUser> WorkplacesUsers { get; set; }

        /// <summary>
        /// Поручения пользователя
        /// </summary>
        public virtual ICollection<TaskEntity> TasksFromUser { get; set; }

        /// <summary>
        /// Поручения пользователю
        /// </summary>
        public virtual ICollection<TaskEntity> TasksToUser { get; set; }


        /// <summary>
        /// Группы пользователя
        /// </summary>
        public virtual ICollection<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// Шаблоны шагов маршрутов
        /// </summary>
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }

        /// <summary>
        /// Шаги маршрутов
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// История поручений создавшие пользователи
        /// </summary>
        public virtual ICollection<TaskHistory> TaskHistoryCreators { get; set; }

        /// <summary>
        /// Удаливыше пользователи 
        /// </summary>
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }

        /// <summary>
        /// Файлы которые загрузил пользователь 
        /// </summary>
        public virtual ICollection<File> Files { get; set; }

        /// <summary>
        /// Созданные документы 
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

        /// <summary>
        /// Замещающий
        /// </summary>
        public virtual ICollection<ClientProfileReplacement> ClientProfileReplacements { get; set; }

        /// <summary>
        /// Заместители
        /// </summary>
        public virtual ICollection<ClientProfileReplacement> ReplacementUsers { get; set; }

        /// <summary>
        /// Заместители на таске 
        /// </summary>
        public virtual ICollection<TaskEntity> TaskReplacementUsers { get; set; }

        /// <summary>
        /// Свойства пользователя 
        /// </summary>
        public virtual ICollection<ClientProfileProperty> ClientProfileProperties { get; set; }

        /// <summary>
        /// Группа ЦФО
        /// </summary>
        public virtual ICollection<DictionaryGroupCFO> GroupCFOs { get; set; }

        /// <summary>
        /// Группа ЦФО ЗГД
        /// </summary>
        public virtual ICollection<DictionaryGroupCFO> GroupCFOZGDs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<DictionaryUserParticipant> UserParticipants { get; set; }

        /// <summary>
        /// Пользователи ЦФО
        /// </summary>
        public virtual ICollection<DictionaryGroupCFOUsers> DictionaryGroupCFOUsers { get; set; }

        /// <summary>
        /// Риск-менеджеры
        /// </summary>
        public virtual ICollection<DictionaryGroupCFO> GroupCFORiskManagers { get; set; }

        /// <summary>
        /// Коллекция логов
        /// </summary>
        /// <returns></returns>
        public virtual ICollection<Log> Logs { get; set; }

        /// <summary>
        /// участники чатов
        /// </summary>
        public virtual ICollection<ChatMember> ChatMembers { get; set; }

        /// <summary>
        /// Ответственные по отделам
        /// </summary>
        public virtual ICollection<DictionaryDepartmentDirectory> DepartmentManagers { get; set; }

        /// <summary>
        /// экономисты Подразделения ОЗМ 
        /// </summary>
        public virtual ICollection<DictionaryDivizionOZM> Economists { get; set; }

        /// <summary>
        /// чатs
        /// </summary>
        public virtual ICollection<Chat> Chats { get; set; }

        public virtual DSSAuthenticationData DssAuthenticationData { get; set; }

        /// <summary>
        /// Группы по поручениям
        /// </summary>
        public virtual ICollection<GroupAssign> GroupAssigns { get; set; }

        /// <summary>
        /// Группы по поручениям
        /// </summary>
        public virtual ICollection<UserGroupAssign> UserGroupAssigns { get; set; }


        public override string ToString()
        {
            return string.Format("{0} {1}. {2}.", LastName, !string.IsNullOrEmpty(FirstName) ? FirstName[0] : ' ', !string.IsNullOrEmpty(MiddleName) ? MiddleName[0] : ' ');
        }
    }
}
