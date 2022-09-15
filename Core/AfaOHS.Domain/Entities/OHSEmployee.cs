using AfaOHS.Domain.Entities.Common;

namespace AfaOHS.Domain.Entities
{
    public class OHSEmployee : PersonBaseEntitiy
    {
        public string CertificateNumber { get; set; }
        public bool IsActive { get; set; }
        public UserRole UserRole { get; set; }
        public string Password { get; set; }
    }
}
