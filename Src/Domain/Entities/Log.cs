using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MMK_IS.Atach.Domain.Entities
{
    public class Log
    {
        public int LogId { get; set; }
        public string LogLevel { get; set; }
        public string RequestContentType { get; set; }
        public string RequestDomain { get; set; }
        public string RequestController { get; set; }
        public string RequestQuery { get; set; }
        public string RequestMethod { get; set; }
        public string Message { get; set; }
        public DateTime? RequestTimestamp { get; set; }
        public string ResponseContentType { get; set; }
        public string ResponseStatusCode { get; set; }
        public DateTime? ResponseTimestamp { get; set; }

        public int ExecuteTime { get; set; }

        /// <summary>
        /// Пользователь сделавший действие
        /// </summary>
        public Guid? UserId { get; set; }
        public virtual ClientProfile User { get; set; }

        #region TD-1404
        /// <summary>
        /// TD-1404 IP-адрес пользователя, совершившего действие
        /// на всякий случай длину зарезервировал под ipv6:
        /// https://overcoder.net/q/6789/%D0%BC%D0%B0%D0%BA%D1%81%D0%B8%D0%BC%D0%B0%D0%BB%D1%8C%D0%BD%D0%B0%D1%8F-%D0%B4%D0%BB%D0%B8%D0%BD%D0%B0-%D0%B4%D0%BB%D1%8F-ip-%D0%B0%D0%B4%D1%80%D0%B5%D1%81%D0%B0-%D0%BA%D0%BB%D0%B8%D0%B5%D0%BD%D1%82%D0%B0-%D0%B4%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0%D1%82%D0%B0
        /// </summary>
        [MaxLength(45)]
        public string CurrentUserIPAddress { get; set; }

        /// <summary>
        /// TD-1404 логин пользователя, совершившего действие
        /// </summary>
        [MaxLength(40)]
        public string CurrentUserLogin { get; set; }
        #endregion
    }
}
