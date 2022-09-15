using AfaOHS.Domain.Entities.Common;

namespace AfaOHS.Domain.Entities
{
    public class ContactEmployee:PersonBaseEntitiy
    {
        public Company Company { get; set; }
    }
}
