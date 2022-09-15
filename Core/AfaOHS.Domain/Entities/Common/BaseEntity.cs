namespace AfaOHS.Domain.Entities.Common
{
    public class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
