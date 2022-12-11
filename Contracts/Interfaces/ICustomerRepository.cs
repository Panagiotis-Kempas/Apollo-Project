using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync(bool trackChanges);

        Task<Customer> GetCustomerAsync(string customerId, bool trackChanges);

        void CreateCustomer(Customer customer);
    }
}
