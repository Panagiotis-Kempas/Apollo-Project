using Entities.Models;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface ITransactionRepository
    {
        Task<PagedList<Transaction>> GetAllTransactionsAsync(string accountId, TransactionParameters transactionParameters, bool trackChanges);
        Task<Transaction> GetTransactionAsync(string accountId, string id, bool trackChanges);

        void CreateTransactionForAccount(string accountId, Transaction transaction);

        Task<IEnumerable<Transaction>> GetAllTransactions(string accountId, bool trackChanges);

        void DeleteTransaction(Transaction transaction);

    }
}
