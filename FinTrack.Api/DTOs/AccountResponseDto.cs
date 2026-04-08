namespace FinTrack.Api.DTOs
{
    public class AccountResponseDto
    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string Currency { get; set; } = string.Empty;
    }
}
