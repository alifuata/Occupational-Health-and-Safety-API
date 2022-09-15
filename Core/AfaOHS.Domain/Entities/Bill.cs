using AfaOHS.Domain.Entities.Common;

namespace AfaOHS.Domain.Entities
{
    public class Bill:BaseEntity
    {
        public Guid BillId { get; set; }
        public Company Company { get; set; }
        public DateTime BillDate { get; set; }
        public string Reason { get; set; }
        public Guid ReasonId { get; set; }
        public string Explanation { get; set; }
        public decimal BillSum { get; set; }
    }
}
