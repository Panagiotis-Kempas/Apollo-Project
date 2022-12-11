using AutoMapper;
using Contracts;
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
    public class BalanceService : IBalanceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BalanceService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BalanceDto>> GetAllBalancesAsync(bool trackChanges)
        {
            var balances = await _repository.Balance.GetAllBalancesAsync(trackChanges);
            
            var balancesDto = _mapper.Map<IEnumerable<BalanceDto>>(balances);
            
            return balancesDto;
        }
    }
}
