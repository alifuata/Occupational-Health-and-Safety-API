namespace AfaOHS.Domain.Entities
{
    public class OccupationalSafetyEducation
    {
        public Guid OccupationalSafetyEducationID { get; set; }
        public OHSEmployee Instructure { get; set; }
        public Company Company { get; set; }
        public DateTime EducationDate { get; set; }
    }
}
