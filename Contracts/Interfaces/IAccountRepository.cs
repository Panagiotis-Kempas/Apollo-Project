using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAccountsAsync(bool trackChanges);
        Task<Account> GetAccountAsync(string accountId, bool trackChanges);

        void CreateAccount(Account account);
    }
}
