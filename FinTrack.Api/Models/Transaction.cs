namespace FinTrack.Api.Models
{
    public class Transaction
    {

        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }

        public TransactionType Type { get; set; }
        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
