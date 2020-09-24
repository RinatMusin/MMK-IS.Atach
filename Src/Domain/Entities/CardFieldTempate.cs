using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class CardFieldTempate
    {
        public Guid CardFieldTempateId { get; set; }

        public Guid CardFieldId { get; set; }
        public Guid TemplateId { get; set; }

        public string Value { get; set; }

        public virtual CardField CardField { get; set; }
        public virtual CardTemplate CardTemplate { get; set; }
    }
}
