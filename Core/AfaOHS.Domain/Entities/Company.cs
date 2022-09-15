namespace AfaOHS.Domain.Entities
{
    public class Company
    {
        public string CompanyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public string ContractNumber { get; set; }
        public NaceCode NaceCode { get; set; }
        public OHSEmployee JobSecuritySpecialist { get; set; }
        public OHSEmployee OccupationalPhysican { get; set; }

    }
}
