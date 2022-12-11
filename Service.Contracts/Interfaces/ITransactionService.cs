
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Interfaces
{
    public interface ITransactionService
    {
        Task<(IEnumerable<TransactionDto> transactions, MetaData metaData)> GetAllTransactionsAsync(string accountId, TransactionParameters transactionParameters, bool trackChanges);

        Task<TransactionDto> GetTransactionAsync(string accountId, string id, bool trackChanges);

        Task<TransactionDto> CreateTransactionForAccountAsync(string accountId, TransactionDto transactionDto, bool trackChanges);

        Task<IEnumerable<EndOfDayBalanceDto>> GetEndOfDayBalances(string accountId, bool trackChanges);

        Task DeleteTransactionForAccount(string accountId, string id, bool trackChanges);

        Task<TransactionDto> UpdateTransactionForAccount(string accountId, string id, TransactionDto transactionDto, bool accTrackChanges, bool transTrackChanges);
    }
}
