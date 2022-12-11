using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class TransactionDto
    {
        public string? TransactionId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string CreditDebitIndicator { get; set; }
        public string Status { get; set; }
        public TransactionCodeDto TransactionCode { get; set; }
        public string? ProprietaryTransactionCode { get; set; }
        public string BookingDate { get; set; }
        public MerchantDetailsDto? MerchantDetails { get; set; }
        public EnrichedDataDto EnrichedData { get; set; }

    }
}
