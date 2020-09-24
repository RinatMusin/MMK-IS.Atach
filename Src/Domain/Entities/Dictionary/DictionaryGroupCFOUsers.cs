using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryGroupCFOUsers
    {
        public Guid GroupCFOUserId { get; set; }

        /// <summary>
        /// ИДентификатор группы ЦФО
        /// </summary>
        public Guid GroupCFOId { get; set; }

        /// <summary>
        /// Название группы цфо 
        /// </summary>
        public string Name { get; set; }

        public Guid UserId { get; set; }

        public virtual ClientProfile User { get; set; }
        public virtual DictionaryGroupCFO GroupCFO { get; set; }

    }
}
