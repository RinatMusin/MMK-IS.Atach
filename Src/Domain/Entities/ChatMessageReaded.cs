using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ChatMessageReaded
    {
        /// <summary>
        /// Чат для общения пользователей документа
        /// </summary>
        public ChatMessageReaded() { }

        /// <summary>
        /// Id чата 
        /// </summary>
        public Guid ChatMessageReadedStatusId { get; set; }

        /// <summary>
        /// Id сообщения 
        /// </summary>
        public Guid ChatMessageId { get; set; }


        /// <summary>
        /// Id участника чата 
        /// </summary>
        public Guid ChatMemberId { get; set; }

        /// <summary>
        /// Статус прочтения: yes\no
        /// </summary>
        public string ChatMessageReadedStatus { get; set; }

        /// <summary>
        /// Дата создания сообщения
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата прочтения
        /// </summary>
        public DateTime LastUpdateDate { get; set; }



        /// <summary>
        /// Участник чата
        /// </summary>
        public virtual ChatMember ChatMember { get; set; }


        /// <summary>
        /// Сообщениe
        /// </summary>
        public virtual ChatMessage ChatMessage { get; set; }

        /// <summary>
        /// Id пользователя участника чата 
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Id документа
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Id чата
        /// </summary>
        public Guid ChatId { get; set; }

    }
}
