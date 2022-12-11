﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace Apollo.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20221211150511_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AccountId");

                    b.Property<string>("AccountHolderNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountSubType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AddressId");

                    b.Property<string>("PartyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Entities.Models.Available", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AvailableId");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BalanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreditDebitIndicator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BalanceId")
                        .IsUnique();

                    b.ToTable("Availables");
                });

            modelBuilder.Entity("Entities.Models.AvailableCreditLine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AvailableCreditLineId");

                    b.Property<string>("AvailableId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AvailableId");

                    b.ToTable("AvailableCreditLine");
                });

            modelBuilder.Entity("Entities.Models.Balance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("BalanceId");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CategoryId");

                    b.Property<double>("Confidence")
                        .HasColumnType("float");

                    b.Property<string>("EnrichedDataId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("EnrichedDataId")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Models.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ClassId");

                    b.Property<double>("Confidence")
                        .HasColumnType("float");

                    b.Property<string>("EnrichedDataId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.HasIndex("EnrichedDataId")
                        .IsUnique();

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Entities.Models.Current", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CurrentId");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BalanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreditDebitIndicator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BalanceId")
                        .IsUnique();

                    b.ToTable("Currents");
                });

            modelBuilder.Entity("Entities.Models.CurrentCreditLine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CurrentCreditLineId");

                    b.Property<string>("CurrentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CurrentId");

                    b.ToTable("CurrentCreditLine");
                });

            modelBuilder.Entity("Entities.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CustomerId");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Entities.Models.EnrichedData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("EnrichedDataId");

                    b.Property<string>("PredictedMerchantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("EnrichedDatas");
                });

            modelBuilder.Entity("Entities.Models.Identifier", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdentifierId");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryIdentification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Identifiers");
                });

            modelBuilder.Entity("Entities.Models.MerchantDetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("MerchantDetailsId");

                    b.Property<string>("MerchantCategoryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("MerchantDetails");
                });

            modelBuilder.Entity("Entities.Models.Party", b =>
                {
                    b.Property<string>("PartyId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PartyId");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAuthorizingParty")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsIndividual")
                        .HasColumnType("bit");

                    b.Property<string>("PartyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartyId");

                    b.HasIndex("AccountId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Entities.Models.PhoneNumber", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PhoneNumberId");

                    b.Property<string>("PartyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("Entities.Models.Transaction", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TransactionId");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BookingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditDebitIndicator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProprietaryTransactionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionId");

                    b.HasIndex("AccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Entities.Models.TransactionCode", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("TransactionCodeId");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("TransactionCodes");
                });

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.HasOne("Entities.Models.Customer", "Customer")
                        .WithMany("Accounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.HasOne("Entities.Models.Party", "Party")
                        .WithMany("Addresses")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");
                });

            modelBuilder.Entity("Entities.Models.Available", b =>
                {
                    b.HasOne("Entities.Models.Balance", "Balance")
                        .WithOne("Available")
                        .HasForeignKey("Entities.Models.Available", "BalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Balance");
                });

            modelBuilder.Entity("Entities.Models.AvailableCreditLine", b =>
                {
                    b.HasOne("Entities.Models.Available", "Available")
                        .WithMany("CreditLines")
                        .HasForeignKey("AvailableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Available");
                });

            modelBuilder.Entity("Entities.Models.Balance", b =>
                {
                    b.HasOne("Entities.Models.Account", "Account")
                        .WithOne("Balances")
                        .HasForeignKey("Entities.Models.Balance", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.HasOne("Entities.Models.EnrichedData", "EnrichedData")
                        .WithOne("Category")
                        .HasForeignKey("Entities.Models.Category", "EnrichedDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnrichedData");
                });

            modelBuilder.Entity("Entities.Models.Class", b =>
                {
                    b.HasOne("Entities.Models.EnrichedData", "EnrichedData")
                        .WithOne("Class")
                        .HasForeignKey("Entities.Models.Class", "EnrichedDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnrichedData");
                });

            modelBuilder.Entity("Entities.Models.Current", b =>
                {
                    b.HasOne("Entities.Models.Balance", "Balance")
                        .WithOne("Current")
                        .HasForeignKey("Entities.Models.Current", "BalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Balance");
                });

            modelBuilder.Entity("Entities.Models.CurrentCreditLine", b =>
                {
                    b.HasOne("Entities.Models.Current", "Current")
                        .WithMany("CreditLines")
                        .HasForeignKey("CurrentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Current");
                });

            modelBuilder.Entity("Entities.Models.EnrichedData", b =>
                {
                    b.HasOne("Entities.Models.Transaction", "Transaction")
                        .WithOne("EnrichedData")
                        .HasForeignKey("Entities.Models.EnrichedData", "TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Entities.Models.Identifier", b =>
                {
                    b.HasOne("Entities.Models.Account", "Account")
                        .WithOne("Identifiers")
                        .HasForeignKey("Entities.Models.Identifier", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Entities.Models.MerchantDetails", b =>
                {
                    b.HasOne("Entities.Models.Transaction", "Transaction")
                        .WithOne("MerchantDetails")
                        .HasForeignKey("Entities.Models.MerchantDetails", "TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Entities.Models.Party", b =>
                {
                    b.HasOne("Entities.Models.Account", "Account")
                        .WithMany("Parties")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Entities.Models.PhoneNumber", b =>
                {
                    b.HasOne("Entities.Models.Party", "Party")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Party");
                });

            modelBuilder.Entity("Entities.Models.Transaction", b =>
                {
                    b.HasOne("Entities.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Entities.Models.TransactionCode", b =>
                {
                    b.HasOne("Entities.Models.Transaction", "Transaction")
                        .WithOne("TransactionCode")
                        .HasForeignKey("Entities.Models.TransactionCode", "TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.Navigation("Balances")
                        .IsRequired();

                    b.Navigation("Identifiers")
                        .IsRequired();

                    b.Navigation("Parties");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Entities.Models.Available", b =>
                {
                    b.Navigation("CreditLines");
                });

            modelBuilder.Entity("Entities.Models.Balance", b =>
                {
                    b.Navigation("Available")
                        .IsRequired();

                    b.Navigation("Current")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Current", b =>
                {
                    b.Navigation("CreditLines");
                });

            modelBuilder.Entity("Entities.Models.Customer", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Entities.Models.EnrichedData", b =>
                {
                    b.Navigation("Category")
                        .IsRequired();

                    b.Navigation("Class")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Party", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("PhoneNumbers");
                });

            modelBuilder.Entity("Entities.Models.Transaction", b =>
                {
                    b.Navigation("EnrichedData")
                        .IsRequired();

                    b.Navigation("MerchantDetails");

                    b.Navigation("TransactionCode")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
