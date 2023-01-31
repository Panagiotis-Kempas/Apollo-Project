using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {

        }

        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Balance>? Balances { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Class>? Classes { get; set; }
        public DbSet<Current>? Currents { get; set; }
        public DbSet<EnrichedData>? EnrichedDatas { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Party>? Parties { get; set; }
        public DbSet<Transaction>? Transactions { get; set; }
        public DbSet<TransactionCode>? TransactionCodes { get; set; }
        public DbSet<Identifier>? Identifiers { get; set; }
        public DbSet<MerchantDetails>? MerchantDetails { get; set; }
        public DbSet<PhoneNumber>? PhoneNumbers { get; set; }
        public DbSet<Available>? Availables { get; set; }
        public DbSet<AvailableCreditLine>? AvailableCreditLines { get; set; }
        public DbSet<AvailableCreditLine>? CurrentCreditLines { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //modelBuilder.ApplyConfiguration(new AccountConfiguration());
            //modelBuilder.ApplyConfiguration(new AvailableConfiguration());
            //modelBuilder.ApplyConfiguration(new BalanceConfiguration());
            //modelBuilder.ApplyConfiguration(new CreditLineConfiguration());
            //modelBuilder.ApplyConfiguration(new CurrentConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new EnrichedDataConfiguration());
            //modelBuilder.ApplyConfiguration(new IdentifierConfiguration());
            //modelBuilder.ApplyConfiguration(new PartyConfiguration());
            //modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }
    }
}
