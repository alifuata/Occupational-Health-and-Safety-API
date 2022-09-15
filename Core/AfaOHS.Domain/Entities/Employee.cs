using AfaOHS.Domain.Entities.Common;

namespace AfaOHS.Domain.Entities
{
    public class Employee:PersonBaseEntitiy
    {
        public string Address { get; set; }    
        public Education Education { get; set; }
    }
}
