using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ChatMessageAttachment
    {
        /// <summary>
        /// Вложения к сообщению в чате
        /// </summary>
        public ChatMessageAttachment() { }

        /// <summary>
        /// Id вложения  
        /// </summary>
        public Guid ChatMessageAttachmentId { get; set; }

        /// <summary>
        /// Id сообщения к которому вложен файл
        /// </summary>
        public Guid ChatMessageId { get; set; }

        /// <summary>
        /// Тип файла - расширение
        /// </summary>
        public string ChatMessageAttachmentType { get; set; }

        /// <summary>
        /// Название файла
        /// </summary>
        public string ChatMessageAttachmentName { get; set; }

        /// <summary>
        /// Состояние вложения: active\deleted 
        /// </summary>
        public string ChatMessageAttachmentStatus { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Сообщениe
        /// </summary>
        public virtual ChatMessage ChatMessage { get; set; }

    }
}
