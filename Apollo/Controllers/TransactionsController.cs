using Apollo.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System.Text.Json;

namespace Apollo.Controllers
{
    [Route("api/accounts/{accountId}/transactions")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public TransactionsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactionsForAccount(string accountId, [FromQuery] TransactionParameters transactionParameters)
        {
            var pagedResult = await _service.TransactionService.GetAllTransactionsAsync(accountId, transactionParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.transactions);
        }

        [HttpGet("{id}", Name = "GetTransacionForAccount")]
        public async Task<IActionResult> GetTransactionForAccount(string accountId, string id)
        {
            var transaction = await _service.TransactionService.GetTransactionAsync(accountId, id, trackChanges: false);
            return Ok(transaction);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateTransactionForAccount(string accountId, [FromBody] TransactionDto transaction)
        {
            var transactionToReturn = await _service.TransactionService.CreateTransactionForAccountAsync(accountId, transaction, trackChanges: false);

            return CreatedAtRoute("GetTransacionForAccount", new { accountId, id = transactionToReturn.TransactionId }, transactionToReturn);
        }

        [HttpGet("balance")]
        public async Task<IActionResult> GalculateEndOfDayBalance(string accountId)
        {
            var result = await _service.TransactionService.GetEndOfDayBalances(accountId, trackChanges: false);

            return Ok(result);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateTransactionForAccount(string accountId, string id, [FromBody] TransactionDto transaction)
        {
            var result =  await _service.TransactionService.UpdateTransactionForAccount(accountId, id, transaction, accTrackChanges: false, transTrackChanges: true);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionForAccount(string accountId, string id)
        {
            await _service.TransactionService.DeleteTransactionForAccount(accountId, id, trackChanges: false);

            return NoContent();
        }
    }
}
