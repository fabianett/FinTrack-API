using FinTrack.Api.DTOs;

namespace FinTrack.Api.Services.Interfaces
{
    public interface IAccountService
    {

        /// <summary>
        /// 1.Returns all accounts asynchronously as a collection of AccountResponseDto.
        /// </summary>
        Task<IEnumerable<AccountResponseDto>> GetAllAccountsAsync();
        /// <summary>
        /// 2.Returns a specific account asynchronously by its unique identifier as an AccountResponseDto.
        /// </summary>
        Task<AccountResponseDto?> GetAccountByIdAsync(Guid id); 
        /// <summary>    
        /// 3.Creates a new account asynchronously using the provided CreateAccountDto and returns the created account as an AccountResponseDto.    
        /// </summary>
        Task<AccountResponseDto> CreateAccountAsync(CreateAccountDto createAccountDto);
    }
}
