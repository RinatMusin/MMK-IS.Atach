using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryGroupCFO
    {
        public DictionaryGroupCFO()
        {
            this.SubSubjectGroupCFOs = new List<DictionarySubSubjectGroupCFO>();
            this.DictionaryGroupCFOUsers = new List<DictionaryGroupCFOUsers>();
        }

        /// <summary>
        /// ИДентификатор группы ЦФО
        /// </summary>
        public Guid GroupCFOId { get; set; }

        /// <summary>
        /// Руководитель при запуске на согласование
        /// </summary>
        public Guid OwnerId { get; set; }
        /// <summary>
        /// Риск-менеджер
        /// </summary>
        public Guid? RiskManagerId { get; set; }
        /// <summary>
        /// Код ЦФО
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Название группы цфо 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Порядок
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Согласующий ЗГД
        /// </summary>
        public Guid? ZGDId { get; set; }

        public virtual ClientProfile Owner { get; set; }
        public virtual ClientProfile RiskManager { get; set; }
        public virtual ClientProfile ZGD { get; set; }
        public virtual ICollection<DictionarySubSubjectGroupCFO> SubSubjectGroupCFOs { get; set; }
        public virtual ICollection<DictionaryGroupCFOUsers> DictionaryGroupCFOUsers { get; set; }
    }
}
