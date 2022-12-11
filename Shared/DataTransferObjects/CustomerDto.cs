using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class CustomerDto
    {
        public string? Id { get; set; }
        public string ProviderName { get; set; }
        public string CountryCode { get; set; }
        public IEnumerable<AccountDto> Accounts { get; set; }
    }
}
