using System;
using System.Collections.Generic;




namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryCounterParty
    {

        public Guid CounterPartyId { get; set; }


        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Полное название
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Руководитель
        /// </summary>
        public string Leader { get; set; }

        /// <summary>
        /// Главный бухгалтер
        /// </summary>
        public string AccountantGeneral { get; set; }

        /// <summary>
        /// Тип юр.лица
        /// </summary>
        public Guid? CounterPartyTypeId { get; set; }

        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string ContactPerson { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Почтовый адрес
        /// </summary>
        public string MailingAddress { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        public string LegalAddress { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Факс
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Сайт компании
        /// </summary>
        public string SiteOfCompany { get; set; }

        /// <summary>
        /// Телекс
        /// </summary>
        public string Telex { get; set; }

        /// <summary>
        /// Клиент
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// Поставщик
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Банк
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string KPP { get; set; }

        /// <summary>
        /// Расчетный счет
        /// </summary>
        public string PaymentAccount { get; set; }

        /// <summary>
        /// Корр. счет
        /// </summary>
        public string CorrAccount { get; set; }

        /// <summary>
        /// БИК
        /// </summary>
        public string BIC { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string INN { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        public string OKPO { get; set; }

        /// <summary>
        /// ОКВЭД
        /// </summary>
        public string OKVED { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        public string Subdivision { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        public string Employee { get; set; }

        /// <summary>
        /// Идентификатор в SAP
        /// </summary>
        public int SAPIdentification { get; set; }

        /// <summary>
        /// Дата последней модификации в SAP
        /// </summary>
        public DateTime DateOfLastModification { get; set; }

 
        public virtual DictionaryCounterPartyType CounterPartyType { get; set; }

    }
}
