using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateTransactionForAccount(string accountId, Transaction transaction)
        {
            transaction.AccountId = accountId;
            Create(transaction);
        }

        public void DeleteTransaction(Transaction transaction)
        {
            Delete(transaction);
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactions(string accountId, bool trackChanges)
        {
            return await FindByCondition(x => x.AccountId.Equals(accountId), trackChanges)
                 .Include(x => x.TransactionCode)
                 .Include(x => x.EnrichedData)
                 .Include(x => x.MerchantDetails).ToListAsync();
        }

        public async Task<PagedList<Transaction>> GetAllTransactionsAsync(string accountId, TransactionParameters transactionParameters, bool trackChanges)
        {
            
            var transactions =  await FindByCondition(x => x.AccountId == accountId , trackChanges)
                .FilterTransactions(transactionParameters.MinAmount, transactionParameters.MaxAmount)
                .Search(transactionParameters.SearchTerm)
                .Include(x=> x.TransactionCode)
                .Include(x=> x.MerchantDetails)
                .Include(x=> x.EnrichedData)
                .OrderBy(x => x.Amount)
            .ToListAsync();

            var count = await FindByCondition(e => e.AccountId.Equals(accountId), trackChanges).CountAsync();

            return new PagedList<Transaction>(transactions,count, transactionParameters.PageNumber, transactionParameters.PageSize);
        }

        public async Task<Transaction> GetTransactionAsync(string accountId, string id, bool trackChanges)
        {
            return await FindByCondition(t => t.AccountId == accountId && t.TransactionId == id, trackChanges)
                .Include(x => x.TransactionCode)
                .Include(x => x.MerchantDetails)
                .Include(x => x.EnrichedData)
                .Include(x=> x.EnrichedData.Category)
                .Include(x=> x.EnrichedData.Class)
                .SingleOrDefaultAsync();
        }      
    }
}
