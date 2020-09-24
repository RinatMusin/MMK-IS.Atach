using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ChatMessagesQnt
    {
        /// <summary>
        /// Количество сообщений в чатах
        /// </summary>
        public ChatMessagesQnt()
        {

            QntUnreadedMessages = 0;
            LastUpdateMessages = new DateTime();
        }

        /// <summary>
        /// Id task
        /// </summary>
        public Guid TaskId { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Id документа
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Количество сообщений
        /// </summary>
        public int QntAllMessages { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int QntUnreadedMessages { get; set; }

        /// <summary>
        /// Последнее изменение
        /// </summary>
        public DateTime LastUpdateMessages { get; set; }

        /// <summary>
        /// task
        /// </summary>
        public virtual TaskEntity Task { get; set; }
    }
}
