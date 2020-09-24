using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Шаблоны
    /// </summary>
    public class CardTemplate
    {
        public CardTemplate()
        {
            this.CardFieldTempates = new List<CardFieldTempate>();
        }

        /// <summary>
        /// Id шаблона
        /// </summary>
        public Guid CardTemplateId { get; set; }

        /// <summary>
        /// Название шаблона
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<CardFieldTempate> CardFieldTempates { get; set; }
    }
}
