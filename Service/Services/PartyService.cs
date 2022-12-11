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
    public class PartyService :IPartyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PartyService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            
        }

        public async Task<IEnumerable<PartyDto>> GetAllPartiesAsync(bool trackChanges)
        {
            var parties = await _repository.Party.GetAllPartiesAsync(trackChanges); 
            
            var partiesDto = _mapper.Map<IEnumerable<PartyDto>>(parties);
            
            return partiesDto;
        }
    }
}
