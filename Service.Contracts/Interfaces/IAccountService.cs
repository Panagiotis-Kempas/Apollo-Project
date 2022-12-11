
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<AccountDto>> GetAllAccountsAsync(bool trackChanges);
        Task<AccountDto> GetAccountAsync(string accountId, bool trackChanges);

        Task<AccountDto> CreateAccountAsync(AccountDto account);
    }
}

