using FinTrack.Api.DTOs;
using FinTrack.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinTrack.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountResponseDto>>> GetAllAccounts()
        {
            var accounts = await _accountService.GetAllAccountsAsync();
            return Ok(accounts);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<AccountResponseDto>> GetAccountById(Guid id)
        {
            var account = await _accountService.GetAccountByIdAsync(id);
            if (account == null)
                return NotFound();
            return Ok(account);


        }
        [HttpPost]
        public async Task<ActionResult<AccountResponseDto>> CreateAccount([FromBody] CreateAccountDto createAccountDto)
        {
            var createdAccount = await _accountService.CreateAccountAsync(createAccountDto);
            return CreatedAtAction(nameof(GetAccountById), new { id = createdAccount.Id }, createdAccount);
        }

    }

}

