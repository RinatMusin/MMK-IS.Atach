using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class RefreshToken
    {
        public string RefreshTokenId { get; set; }
        public string Subject { get; set; }
        public string ClientId { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        public string ProtectedTicket { get; set; }
        public virtual Client Client { get; set; }
    }
}
