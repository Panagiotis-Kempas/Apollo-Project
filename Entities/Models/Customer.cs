using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Customer
    {
        [Column("CustomerId")]
        public string Id { get; set; }
        public string ProviderName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
