using System;

namespace MMK_IS.Atach.Domain.Entities
{
	/// <summary>
    /// значение поля карточки по умолчанию
    /// </summary>
    public class CardFieldDefaultValue
    {
        public Guid CardFieldDefaultValueId { get; set; }
        public Guid CardFieldId { get; set; }
        public string Value { get; set; }

        public virtual CardField CardField { get; set; }
    }
}
