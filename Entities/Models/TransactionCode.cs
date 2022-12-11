using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class TransactionCode
    {
        [Column("TransactionCodeId")]
        public string Id { get; set; }
        public string Code { get; set; }
        public string SubCode { get; set; }
        public string TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}