
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Interfaces
{
    public interface IBalanceService
    {
        Task<IEnumerable<BalanceDto>> GetAllBalancesAsync(bool trackChanges);
    }
}
