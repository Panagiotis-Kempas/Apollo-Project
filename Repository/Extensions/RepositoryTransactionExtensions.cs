using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Extensions
{
    public static class RepositoryTransactionExtensions
    {
        public static IQueryable<Transaction> FilterTransactions(this IQueryable<Transaction> transactions, double minAmount, double maxAmount)
            => transactions.Where(t => (t.Amount >= minAmount && t.Amount <= maxAmount));

        public static IQueryable<Transaction> Search(this IQueryable<Transaction> transactions, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return transactions;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return transactions.Where(e => e.Description.ToLower().Contains(lowerCaseTerm));
        }
    }
}
