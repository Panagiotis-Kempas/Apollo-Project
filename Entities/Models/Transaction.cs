using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Transaction
    {
        [Column("TransactionId")]
        [Key]
        public string TransactionId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string CreditDebitIndicator { get; set; }
        public string Status { get; set; }
        public TransactionCode TransactionCode { get; set; }
        public string? ProprietaryTransactionCode { get; set; }
        public string BookingDate { get; set; }
        public MerchantDetails? MerchantDetails { get; set; }
        public EnrichedData EnrichedData { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }

    }
}
