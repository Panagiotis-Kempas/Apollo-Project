
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Account
    {
        [Column("AccountId")]
        public string AccountId { get; set; }
        public string CurrencyCode { get; set; }
        public string DisplayName { get; set; }
        public string AccountHolderNames { get; set; }
        public string AccountType { get; set; }
        public string AccountSubType { get; set; }
        public Identifier Identifiers { get; set; }
        public ICollection<Party> Parties { get; set; }
        public Balance Balances { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
