using System;


namespace MMK_IS.Atach.Domain.Entities
{
    public class DSSAuthenticationData
    {
        public DSSAuthenticationData()
        {
            HashSigning = false;
        }
        /// CryptoPro
        public Guid DSSAuthenticationDataId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PersonalIdentificationNumber { get; set; }
        public bool HashSigning { get; set; }

        /// Kontur
        public string Thumbprint { get; set; }
        public string Subject { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public byte[] KonturCertificate { get; set; }

        public virtual ClientProfile ClientProfile { get; set; }
    }
}
