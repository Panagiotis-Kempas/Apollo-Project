using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Balance
    {
        [Column("BalanceId")]
        public string Id { get; set; }
        public Current Current { get; set; }
        public Available Available { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
    }
}
