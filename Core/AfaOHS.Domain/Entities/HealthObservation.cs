namespace AfaOHS.Domain.Entities
{
    public class HealthObservation
    {
        public Guid HealthObservationId { get; set; }
        public OHSEmployee WorkplacePhysican { get; set; }
        public Employee Employee { get; set; }
        public DateTime ObservationDate { get; set; }
        public DateTime NextObservationDate { get; set; }

    }
}
