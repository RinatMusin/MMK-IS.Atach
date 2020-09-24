using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ChatMember
    {
        /// <summary>
        /// Чат для общения пользователей документа
        /// </summary>
        public ChatMember() { }

        /// <summary>
        /// Id участника чата 
        /// </summary>
        public Guid ChatMemberId { get; set; }

        /// <summary>
        /// Id чата 
        /// </summary>
        public Guid ChatId { get; set; }


        /// <summary>
        /// Профиль участника чата
        /// </summary>
        public Guid ChatMemberProfileId { get; set; }

        /// <summary>
        /// Профиль участника чата
        /// </summary>
        public Guid? DelegatingUserProfileId { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }


        /// <summary>
        /// Профиль участника 
        /// </summary>
        public virtual ClientProfile ChatMemberProfile { get; set; }

        /// <summary>
        /// Профиль замещаемого\ делегирующего свои полномочия
        /// </summary>
        //public virtual ClientProfile DelegatingUserProfile { get; set; }

        /// <summary>
        /// Чат
        /// </summary>
        public virtual Chat Chat { get; set; }

        /// <summary>
        /// сообщения  чата
        /// </summary>
        public virtual ICollection<ChatMessage> ChatMessages { get; set; }

        /// <summary>
        /// Инфа о прочтении сообщения
        /// </summary>
        public virtual ICollection<ChatMessageReaded> ChatMessageReadeds { get; set; }


    }
}
