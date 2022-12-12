using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class AccountDto
    {
        public string? AccountId { get; set; }
        public string CurrencyCode { get; set; }
        public string DisplayName { get; set; }
        public string AccountHolderNames { get; set; }
        public string AccountType { get; set; }
        public string AccountSubType { get; set; }
        public IdentifierDto Identifiers { get; set; }
        public IEnumerable<PartyDto> Parties { get; set; }
        public BalanceDto Balances { get; set; }
        public IEnumerable<TransactionDto> Transactions { get; set; }

    }
}
