using Apollo.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;

namespace Apollo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AccountsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet("{id}", Name = "AccountById")]
        public async Task<IActionResult> GetAccount(string id)
        {
            var account = await _service.AccountService.GetAccountAsync(id, trackChanges: false);

            return Ok(account);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAccount([FromBody] AccountDto account)
        {          
            var createdAccount = await _service.AccountService.CreateAccountAsync(account,trackChanges:false);

            return CreatedAtRoute("AccountById", new { id = createdAccount.AccountId }, createdAccount);
        }

    }
}
