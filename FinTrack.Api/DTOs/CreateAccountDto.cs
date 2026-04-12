using System.ComponentModel.DataAnnotations;
namespace FinTrack.Api.DTOs
{
    public class CreateAccountDto
    {
        [Required]
        [StringLength(60)]

        public string Name { get; set; } = string.Empty;

        [Range(-1000,50000)]
        public decimal InitialBalance { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; } = "USD";


    }
}
