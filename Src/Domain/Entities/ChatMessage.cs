using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ChatMessage
    {
        /// <summary>
        /// Чат для общения пользователей документа
        /// </summary>
        public ChatMessage()
        {
            this.ChatMessageAttachments = new List<ChatMessageAttachment>();
            this.ChatMessageReadeds = new List<ChatMessageReaded>();
        }

        /// <summary>
        /// Id участника чата 
        /// </summary>
        public Guid ChatMessageId { get; set; }

        /// <summary>
        /// Id чата 
        /// </summary>
        public Guid ChatId { get; set; }

        /// <summary>
        /// Автор сообщения
        /// </summary>
        public Guid? ChatMemberId { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string ChatMessageText { get; set; }
        /// <summary>
        /// Ссылка на аватар
        /// </summary>
        public string ChatAvatarImageLink { get; set; }

        /// <summary>
        /// Дата создания сообщения 
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата последнего изменения сообщения
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Статус сообщения: Active\Updated\Deleted
        /// </summary>
        public string ChatMessageStatus { get; set; }



        /// <summary>
        /// Автор сообщения
        /// </summary>
        public virtual ChatMember ChatMember { get; set; }

        /// <summary>
        /// Чат
        /// </summary>
        public virtual Chat Chat { get; set; }

        /// <summary>
        /// Вложения в сообщения
        /// </summary>
        public virtual ICollection<ChatMessageAttachment> ChatMessageAttachments { get; set; }

        /// <summary>
        /// Участники чата
        /// </summary>
        public virtual ICollection<ChatMember> ChatMembers { get; set; }
        /// <summary>
        /// Инфа о прочтении сообщения
        /// </summary>
        public virtual ICollection<ChatMessageReaded> ChatMessageReadeds { get; set; }
    }
}
