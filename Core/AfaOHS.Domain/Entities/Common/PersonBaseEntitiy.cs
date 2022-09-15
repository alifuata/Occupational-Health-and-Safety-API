using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities.Common
{
    public class PersonBaseEntitiy:BaseEntity
    {
        [Key]
        public string NationalID { get; set; }
        public string NameSurname { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public Occupation Occupation { get; set; }
    }
}
