using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class TransactionNotFoundException : NotFoundException
    {
        public TransactionNotFoundException(string transactionId)
            : base($"Transaction with id: {transactionId} doesn't exist in the database.")
        {

        }
    }
}
