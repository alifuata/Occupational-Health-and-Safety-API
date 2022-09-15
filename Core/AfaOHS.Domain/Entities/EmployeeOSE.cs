using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities
{
    public class EmployeeOSE
    {
        [Key]
        public int EmployeeOSEId { get; set; }
        public Employee Employee { get; set; }
        public OccupationalSafetyEducation OccupationalSafetyEducation { get; set; }
        public int PreTestScore { get; set; }
        public int TestScore { get; set; }
        public DateTime NextEducationDate { get; set; }
    }
}
