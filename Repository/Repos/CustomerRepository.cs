using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(a => a.ProviderName)
                .Include(x => x.Accounts)
                .ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(string customerId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id == customerId, trackChanges)
                .Include(x=> x.Accounts)
                .SingleOrDefaultAsync();
        }
    }
}
