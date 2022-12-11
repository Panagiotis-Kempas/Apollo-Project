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
    public class BalanceRepository : RepositoryBase<Balance>, IBalanceRepository
    {
        public BalanceRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {

        }

        public async Task<IEnumerable<Balance>> GetAllBalancesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<Balance> GetBalanceByAccountIdAsync(string accountId, bool trackChanges)
        {
            return await FindByCondition(x=> x.AccountId == accountId,trackChanges)
                .Include(x=> x.Current)
                .Include(x=> x.Available).SingleOrDefaultAsync();
                
        }
    }
}
