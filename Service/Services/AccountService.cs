using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AccountService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<AccountDto> CreateAccountAsync(AccountDto account)
        {
            var accountEntity = _mapper.Map<Account>(account);

            _repository.Account.CreateAccount(accountEntity);

            await _repository.SaveAsync();

            var accountToReturn = _mapper.Map<AccountDto>(accountEntity);

            return accountToReturn;
        }

        public async Task<AccountDto> GetAccountAsync(string accountId, bool trackChanges)
        {
            var account = await _repository.Account.GetAccountAsync(accountId, trackChanges);
            if (account == null)
                throw new AccountNotFoundException(accountId);

            var accountDto = _mapper.Map<AccountDto>(account);

            return accountDto;
        }

        public async Task<IEnumerable<AccountDto>> GetAllAccountsAsync(bool trackChanges)
        {
            var accounts = await _repository.Account.GetAllAccountsAsync(trackChanges);

            var accountsDto = _mapper.Map<IEnumerable<AccountDto>>(accounts);

            return accountsDto;
        }
    }
}
