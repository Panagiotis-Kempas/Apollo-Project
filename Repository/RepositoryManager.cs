using Contracts;
using Contracts.Interfaces;
using Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAccountRepository> _accountRepository;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<IBalanceRepository> _balanceRepository;
        private readonly Lazy<IPartyRepository> _partyRepository;
        private readonly Lazy<ITransactionRepository> _transactionRepository;
        
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext= repositoryContext;
            _accountRepository = new Lazy<IAccountRepository>(() => new AccountRepository(repositoryContext));
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _balanceRepository = new Lazy<IBalanceRepository>(() => new BalanceRepository(repositoryContext));
            _partyRepository = new Lazy<IPartyRepository>(() => new PartyRepository(repositoryContext));
            _transactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(repositoryContext));
            
        }
        public ICustomerRepository Customer => _customerRepository.Value;

        public IAccountRepository Account => _accountRepository.Value;

        public IBalanceRepository Balance => _balanceRepository.Value;

        public IPartyRepository Party => _partyRepository.Value;

        public ITransactionRepository Transaction => _transactionRepository.Value;

        public async Task SaveAsync()
        {
           await _repositoryContext.SaveChangesAsync();
        }
    }
}
