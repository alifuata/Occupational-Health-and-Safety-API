using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string EducationType { get; set; }
    }
}
