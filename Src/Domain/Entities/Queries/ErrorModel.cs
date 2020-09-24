using System;

namespace MMK_IS.Atach.Domain.Entities.Queries
{
    public class ErrorModel
    {
        public DateTime? RequestTimestamp { get; set; }
        public string Message { get; set; }
        public string RequestUri { get; set; }
        public string RequestMethod { get; set; }
    }
}
