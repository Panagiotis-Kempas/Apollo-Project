using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext):base(repositoryContext) { }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync(bool trackChanges)
        {
           return await  FindAll(trackChanges).OrderBy(a=> a.DisplayName)
                 .Include(x => x.Balances)
                .Include(x => x.Identifiers)
                .Include(x => x.Parties).ToListAsync();
        }

        public async Task<Account> GetAccountAsync(string accountId, bool trackChanges)
        {
            return await FindByCondition(x=> x.AccountId == accountId,trackChanges)
                .Include(x=> x.Balances)
                .Include(x=> x.Identifiers)
                .Include(x=> x.Parties).SingleOrDefaultAsync();
        }

        public void CreateAccount(Account account)
        {
            Create(account);
        }
    }
}
