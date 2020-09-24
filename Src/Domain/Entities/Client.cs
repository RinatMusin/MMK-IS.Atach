using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class Client
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string Name { get; set; }
        public int ApplicationTypeId { get; set; }
        public bool Active { get; set; }
        public int RefreshTokenLifeTime { get; set; }
        public string AllowedOrigin { get; set; }

        public virtual ApplicationType ApplicationType { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

    }

}
