using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CurrentCreditLine
    {
        [Column("CurrentCreditLineId")]
        public string Id { get; set; }
        public string CurrentId { get; set; }
        public Current Current { get; set; }
    }
}
