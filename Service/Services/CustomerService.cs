using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CustomerService  :ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CustomerDto> CreateCustomerAsync(CustomerDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);

            _repository.Customer.CreateCustomer(customerEntity);

            await _repository.SaveAsync();

            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);

            return customerToReturn;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges)
        {
            var customers = await _repository.Customer.GetAllCustomersAsync(trackChanges);
            
            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers); 
            
            return customersDto;

        }

        public async Task<CustomerDto> GetCustomerAsync(string customerId, bool trackChanges)
        {
            var customer = await _repository.Customer.GetCustomerAsync(customerId, trackChanges);
            if (customer == null)
                throw new CustomerNotFoundException(customerId);

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;
        }
    }
}
