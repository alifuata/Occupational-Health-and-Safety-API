using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities
{
    public class SUTData
    {
        [Key]
        public int SUTDataId { get; set; }
        public int EmployeeCount { get; set; }
        public decimal OSFee { get; set; }
        public decimal OHFee { get; set; }
        public decimal OHSFee { get; set; }
        public DangerLevel DangerLevel { get; set; }
    }
}
