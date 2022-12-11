using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class EndOfDayBalanceDto
    {
        public string Date { get; set; }
        public double EndOfDayBalance { get; set; }
        public double TotalDebits { get; set; }
        public double TotalCredits { get; set; }
    }
}
