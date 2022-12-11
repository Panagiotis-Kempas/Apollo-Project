using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class MerchantDetails
    {
        [Column("MerchantDetailsId")]
        public string Id { get; set; }
        public string? MerchantName { get; set; }
        public string? MerchantCategoryCode { get; set; }
        public string TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}