using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
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
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper,UserManager<User> userManager, IConfiguration configuration)
        {
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, logger, mapper));
            _accountService = new Lazy<IAccountService>(() => new AccountService(repositoryManager, logger, mapper));
            _partyService = new Lazy<IPartyService>(() => new PartyService(repositoryManager, logger, mapper));
            _balanceService = new Lazy<IBalanceService>(() => new BalanceService(repositoryManager, logger, mapper));
            _transactionService = new Lazy<ITransactionService>(() => new TransactionService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }
        public ICustomerService CustomerService => _customerService.Value;
        public IAccountService AccountService => _accountService.Value;
        public IPartyService PartyService => _partyService.Value;
        public IBalanceService BalanceService => _balanceService.Value;
        public ITransactionService TransactionService => _transactionService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
