
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomersAsync(bool trackChanges);

        Task<CustomerDto> GetCustomerAsync(string customerId, bool trackChanges);

        Task<CustomerDto> CreateCustomerAsync(CustomerDto customer);
    }
}
