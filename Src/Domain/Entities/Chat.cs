using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class Chat
    {
        /// <summary>
        /// Чат для общения пользователей документа
        /// </summary>
        public Chat()
        {
            this.ChatMembers = new List<ChatMember>();
            this.ChatMessages = new List<ChatMessage>();
        }

        /// <summary>
        /// Id чата 
        /// </summary>
        public Guid ChatId { get; set; }

        /// <summary>
        /// Id чата 
        /// </summary>
        public string ComplexChatId { get; set; }

        /// <summary>
        /// Id документа
        /// </summary>
        public Guid DocumentId { get; set; }


        /// <summary>
        /// Название чата
        /// </summary>
        public string ChatName { get; set; }

        /// <summary>
        /// Признак общего чата
        /// </summary>
        public Boolean IsPublicChat { get; set; }

        /// <summary>
        /// Аватар  чата
        /// </summary>
        public string ChatAvatarImageLink { get; set; }

        /// <summary>
        /// Аватар  чата
        /// </summary>
        public string ChatDescription { get; set; }

        /// <summary>
        /// Автор чата
        /// </summary>
        public Guid ChatCreatedProfileId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Профиль создателя
        /// </summary>
        public virtual ClientProfile ChatCreatedProfile { get; set; }

        /// <summary>
        /// Профиль создателя
        /// </summary>
        public virtual Document Document { get; set; }

        /// <summary>
        /// Участники чата
        /// </summary>
        public virtual ICollection<ChatMember> ChatMembers { get; set; }

        /// <summary>
        /// Сообщения
        /// </summary>
        public virtual ICollection<ChatMessage> ChatMessages { get; set; }

    }
}
