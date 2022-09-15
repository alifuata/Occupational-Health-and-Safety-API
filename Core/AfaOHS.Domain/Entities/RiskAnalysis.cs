namespace AfaOHS.Domain.Entities
{
    public class RiskAnalysis
    {
        public Guid RiskAnalysisId { get; set; }
        public Company Company { get; set; }
        public OHSEmployee Analyzer { get; set; }
        public DateTime AnalysisDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime FixDate { get; set; }
        public int Score { get; set; }
        public bool IsFixed { get; set; }
    }
}
