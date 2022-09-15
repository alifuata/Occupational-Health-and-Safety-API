using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities
{

    public class EmployeeCompany
    {
        [Key]
        public int EmployeeCompanyId { get; set; }
        public Employee Employee { get; set; }
        public Company Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime QuitDate { get; set; } = new DateTime(1900, 01, 01);
        public Occupation Occupation { get; set; }
    }
}
