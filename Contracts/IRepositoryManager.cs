using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customer { get; }
        IAccountRepository Account { get; }
        IBalanceRepository Balance { get; }
        IPartyRepository Party { get; }
        ITransactionRepository Transaction { get; }

        Task SaveAsync();
    }
}
