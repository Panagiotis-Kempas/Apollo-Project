using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AvailableCreditLine
    {
        [Column("AvailableCreditLineId")]
        public string Id { get; set; }
        public string AvailableId { get; set; }
        public Available Available { get; set; }
    }
}
