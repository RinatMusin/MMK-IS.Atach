using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class SignRequestLog
    {
        public Guid LogId { get; set; }
        public string RequestURL { get; set; }
        public String Authorization { get; set; }
        public string RequestContentType { get; set; }
        public String RequestContent { get; set; }
        public string RequestQuery { get; set; }
        public string RequestMethod { get; set; }
        public string ResponseContent { get; set; }
        public string ResponseContentType { get; set; }
        public string ResponseStatusCode { get; set; }
        public DateTime ResponseTimestamp { get; set; }
        public DateTime RequestTimestamp { get; set; }
        public Guid DocumentId { get; set; }
        public Guid? UniqueTransactionId { get; set; }
    }
}
