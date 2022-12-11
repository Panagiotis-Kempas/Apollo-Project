using AutoMapper;
using Contracts;
using Service.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<IAccountService> _accountService;
        private readonly Lazy<IPartyService> _partyService;
        private readonly Lazy<IBalanceService> _balanceService;
        private readonly Lazy<ITransactionService> _transactionService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, logger, mapper));
            _accountService = new Lazy<IAccountService>(() => new AccountService(repositoryManager, logger, mapper));
            _partyService = new Lazy<IPartyService>(() => new PartyService(repositoryManager, logger, mapper));
            _balanceService = new Lazy<IBalanceService>(() => new BalanceService(repositoryManager, logger, mapper));
            _transactionService = new Lazy<ITransactionService>(() => new TransactionService(repositoryManager, logger, mapper));
        }
        public ICustomerService CustomerService => _customerService.Value;
        public IAccountService AccountService => _accountService.Value;
        public IPartyService PartyService => _partyService.Value;
        public IBalanceService BalanceService => _balanceService.Value;
        public ITransactionService TransactionService => _transactionService.Value;
    }
}
