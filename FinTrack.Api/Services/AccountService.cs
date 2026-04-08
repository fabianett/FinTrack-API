using FinTrack.Api.DTOs;
using FinTrack.Api.Services.Interfaces;

namespace FinTrack.Api.Services
{
    public class AccountService : IAccountService
    {
        public Task<AccountResponseDto> CreateAccountAsync(CreateAccountDto createAccountDto)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<AccountResponseDto>> GetAllAccountsAsync()
        {
            throw new NotImplementedException();
        }
        public Task<AccountResponseDto?> GetAccountByIdAsync(Guid id)
        {
            throw new NotImplementedException();

        }
    }
}
