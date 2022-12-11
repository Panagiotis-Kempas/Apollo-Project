using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class BalanceDto
    {
        public string? Id { get; set; }
        public CurrentDto Current { get; set; }
        public AvailableDto Available { get; set; }

    }
}
