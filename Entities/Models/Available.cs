using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Available
    {
        [Column("AvailableId")]
        public string Id { get; set; }
        public double Amount { get; set; }
        public string CreditDebitIndicator { get; set; }
        public ICollection<AvailableCreditLine> CreditLines { get; set; }
        public string BalanceId { get; set; }
        public Balance Balance { get; set; }
    }
}
