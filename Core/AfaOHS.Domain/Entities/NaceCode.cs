using System.ComponentModel.DataAnnotations;

namespace AfaOHS.Domain.Entities
{
    public class NaceCode
    {
        [Key]
        public int NaceCodeId { get; set; }
        public string NACECode { get; set; }
        public string Explanation { get; set; }
        public DangerLevel DangerLevel { get; set; }
    }
}
