using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransactionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<TransactionDto> CreateTransactionForAccountAsync(string accountId, TransactionDto transactionDto, bool trackChanges)
        {
            await CheckIfAccountExists(accountId, trackChanges);

            var transactionEntity = _mapper.Map<Transaction>(transactionDto);

            _repository.Transaction.CreateTransactionForAccount(accountId, transactionEntity);
            await _repository.SaveAsync();

            var transactionToReturn = _mapper.Map<TransactionDto>(transactionEntity);

            return transactionToReturn;
        }

        public async Task<(IEnumerable<TransactionDto> transactions, MetaData metaData)> GetAllTransactionsAsync(string accountId, TransactionParameters transactionParameters, bool trackChanges)
        {
            if (!transactionParameters.ValidAmountRange)
                throw new MaxDateRangeBadRequestException();

            await CheckIfAccountExists(accountId, trackChanges);

            var transactionsWithMetadata = await _repository.Transaction.GetAllTransactionsAsync(accountId, transactionParameters, trackChanges);

            var transactionsDto = _mapper.Map<IEnumerable<TransactionDto>>(transactionsWithMetadata);

            return (transactions: transactionsDto, metaData: transactionsWithMetadata.MetaData);
        }

        public async Task<IEnumerable<EndOfDayBalanceDto>> GetEndOfDayBalances(string accountId, bool trackChanges)
        {
            await CheckIfAccountExists(accountId, trackChanges);

            var transactions = await _repository.Transaction.GetAllTransactions(accountId, trackChanges);

            if (!transactions.Any())
                return Enumerable.Empty<EndOfDayBalanceDto>();

            var accountBalance = await _repository.Balance.GetBalanceByAccountIdAsync(accountId, trackChanges);
            var amount = accountBalance.Current.Amount;

            return CalculteEndOfDayBalances(transactions, amount);
        }



        public async Task<TransactionDto> GetTransactionAsync(string accountId, string id, bool trackChanges)
        {
            await CheckIfAccountExists(accountId, trackChanges);

            var transaction = await _repository.Transaction.GetTransactionAsync(accountId, id, trackChanges);

            if (transaction is null)
                throw new TransactionNotFoundException(id);

            var transactionDto = _mapper.Map<TransactionDto>(transaction);

            return transactionDto;
        }

        private async Task CheckIfAccountExists(string id, bool trackChanges)
        {
            var account = await _repository.Account.GetAccountAsync(id, trackChanges);

            if (account == null)
                throw new AccountNotFoundException(id);
        }

        private List<EndOfDayBalanceDto> CalculteEndOfDayBalances(IEnumerable<Transaction> transactions, double current)
        {
            var groupedTransactions = transactions.GroupBy(x => x.BookingDate);

            var balances = new List<EndOfDayBalanceDto>();
            foreach (var group in groupedTransactions)
            {
                var date = DateTime.Parse(group.Key).Subtract(new TimeSpan(1, 0, 0, 0)).ToShortDateString();
                double totalCredits = 0;
                double totalDebits = 0;
                foreach (var transaction in group)
                {
                    if (transaction.CreditDebitIndicator == "Debit")
                        totalDebits += transaction.Amount;
                    else if (transaction.CreditDebitIndicator == "Credit")
                        totalCredits += transaction.Amount;
                    else
                        continue;
                }

                var balance = (current + totalCredits) - totalDebits;

                var endOfDayBalanceDto = new EndOfDayBalanceDto()
                {
                    Date = date,
                    EndOfDayBalance = Math.Round(balance, 2),
                    TotalCredits = Math.Round(totalCredits, 2),
                    TotalDebits = Math.Round(totalDebits, 2),
                };
                balances.Add(endOfDayBalanceDto);
            }
            return balances;
        }

        public async Task DeleteTransactionForAccount(string accountId, string id, bool trackChanges)
        {
            await CheckIfAccountExists(accountId, trackChanges);

            var transactionForAccount = await _repository.Transaction.GetTransactionAsync(accountId, id, trackChanges);

            if (transactionForAccount is null)
                throw new TransactionNotFoundException(id);

            _repository.Transaction.DeleteTransaction(transactionForAccount);
            await _repository.SaveAsync();
        }

        public async Task<TransactionDto> UpdateTransactionForAccount(string accountId, string id, TransactionDto transactionDto, bool accTrackChanges, bool transTrackChanges)
        {
            await CheckIfAccountExists(accountId,accTrackChanges);

            var transactionForAccount = await _repository.Transaction.GetTransactionAsync(accountId, id, transTrackChanges);

            if (transactionForAccount is null)
                throw new TransactionNotFoundException(id);

            _mapper.Map(transactionDto, transactionForAccount);
            await _repository.SaveAsync();

            var updatedTransaction = _mapper.Map<TransactionDto>(transactionForAccount);

            return updatedTransaction;
        }
    }
}
