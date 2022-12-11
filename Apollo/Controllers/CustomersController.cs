using Apollo.ActionFilters;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Interfaces;
using Shared.DataTransferObjects;

namespace Apollo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CustomersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        { 
            var customers = await _serviceManager.CustomerService.GetAllCustomersAsync(trackChanges: false);
            return Ok(customers); 
        }

        [HttpGet("{id}", Name = "CustomerById")]
        public async Task<IActionResult> GetCustomerAsync(string id)
        {
            var customer = await _serviceManager.CustomerService.GetCustomerAsync(id,trackChanges: false);

            return Ok(customer);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCustomer([FromBody]CustomerDto customerDto)
        {
            var createdCustomer = await _serviceManager.CustomerService.CreateCustomerAsync(customerDto);

            return CreatedAtRoute("CustomerById", new { id = createdCustomer.Id }, createdCustomer);
        }
    }
}
