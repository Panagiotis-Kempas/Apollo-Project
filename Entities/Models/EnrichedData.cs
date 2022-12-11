using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class EnrichedData
    {
        [Column("EnrichedDataId")]
        public string Id { get; set; }
        public Category Category { get; set; }
        public Class Class { get; set; }
        public string? PredictedMerchantName { get; set; }
        public string TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}
