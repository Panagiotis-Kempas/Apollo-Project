using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures
{
    public class TransactionParameters : RequestParameters
    {
        public double MinAmount { get; set; }
        public double MaxAmount { get; set; } = double.MaxValue;

        public bool ValidAmountRange => MaxAmount > MinAmount;

        public string? SearchTerm { get; set; }
    }
}
