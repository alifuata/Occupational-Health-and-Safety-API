using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities
{
    public class DangerLevel
    {
        [Key]
        public int DangerLevelId { get; set; }
        public string DangerLevelValue { get; set; }
    }
}
