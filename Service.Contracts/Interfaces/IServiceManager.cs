using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Interfaces
{
    public interface IServiceManager
    {
        IAccountService AccountService { get; }
        ICustomerService CustomerService { get; }
        IBalanceService BalanceService { get; }
        IPartyService PartyService { get; }
        ITransactionService TransactionService { get; }
    }
}
