using FinTrack.Api.Data;
using FinTrack.Api.Models;
using FinTrack.Api.DTOs;
using FinTrack.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Services
{
    public class AccountService : IAccountService
    {

        private readonly FinTrackDbContext _context;
        public AccountService(FinTrackDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AccountResponseDto>> GetAllAccountsAsync()
        {
            var accounts = await _context.Accounts
            .Select(account => new AccountResponseDto
            {
                Id = account.Id,
                Name = account.Name,
                Balance = account.Balance,
                Currency = account.Currency
            }).ToListAsync();

            return accounts;
        }

        public async Task<AccountResponseDto?> GetAccountByIdAsync(Guid id)
        {
            var account = await _context.Accounts
                .Where(account => account.Id == id)
                .Select(account => new AccountResponseDto
                {
                    Id = account.Id,
                    Name = account.Name,
                    Balance = account.Balance,
                    Currency = account.Currency
                }).FirstOrDefaultAsync(account => account.Id == id);

            return account;
        }
        public async Task<AccountResponseDto> CreateAccountAsync(CreateAccountDto createAccountDto)
        {
            var account = new Account()
            {
                Id = Guid.NewGuid(),
                Name = createAccountDto.Name,
                Balance = createAccountDto.InitialBalance,
                Currency = createAccountDto.Currency,
            };

            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            var response = new AccountResponseDto
            {
                Id = account.Id,
                Name = account.Name,
                Balance = account.Balance,
                Currency = account.Currency
            };
            return response;
        }


    }
}
