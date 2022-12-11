using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IBalanceRepository
    {
        Task<IEnumerable<Balance>> GetAllBalancesAsync(bool trackChanges);
        Task<Balance> GetBalanceByAccountIdAsync(string accountId, bool trackChanges);
    }
}
