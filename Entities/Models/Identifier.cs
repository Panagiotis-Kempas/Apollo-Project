using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Identifier
    {
        [Column("IdentifierId")]
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string BankCode { get; set; }
        public string? Iban { get; set; }
        public string? SecondaryIdentification { get; set; }

        //Navigation Properties
        public string AccountId { get; set; }
        public Account Account { get; set; }
    }
}
