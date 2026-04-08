namespace FinTrack.Api.Models
{
    public class Account
    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "USD";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
