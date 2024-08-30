﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace ChallengeTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240829164725_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChallengeService.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("AccountNumber");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Balance");

                    b.Property<DateTime?>("LastWithdrawalDate")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("LastWithdrawalDate");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Account", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"),
                            AccountNumber = "ACC123456789",
                            Balance = 1000.00m,
                            LastWithdrawalDate = new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3244),
                            UserName = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"),
                            AccountNumber = "ACC987654321",
                            Balance = 2000.00m,
                            LastWithdrawalDate = new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3256),
                            UserName = "Jane Smith"
                        },
                        new
                        {
                            Id = new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"),
                            AccountNumber = "ACC112233445",
                            Balance = 1500.00m,
                            LastWithdrawalDate = new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3258),
                            UserName = "Alice Johnson"
                        },
                        new
                        {
                            Id = new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"),
                            AccountNumber = "ACC556677889",
                            Balance = 500.00m,
                            LastWithdrawalDate = new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3260),
                            UserName = "Bob Brown"
                        },
                        new
                        {
                            Id = new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"),
                            AccountNumber = "ACC998877665",
                            Balance = 750.00m,
                            LastWithdrawalDate = new DateTime(2024, 8, 29, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(3263),
                            UserName = "Charlie Davis"
                        });
                });

            modelBuilder.Entity("ChallengeService.Models.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("CardNumber");

                    b.Property<int>("FailedAttempts")
                        .HasColumnType("int")
                        .HasColumnName("FailedAttempts");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit")
                        .HasColumnName("IsLocked");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("Pin");

                    b.Property<string>("PlaceHolderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PlaceHolderName");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Card", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("311339e9-4058-4064-825b-19009a329634"),
                            AccountId = new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"),
                            CardNumber = "1111222233334444",
                            FailedAttempts = 0,
                            IsLocked = false,
                            Pin = "1234",
                            PlaceHolderName = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("c1d6c314-5566-4ae2-9868-ed397acde6ad"),
                            AccountId = new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"),
                            CardNumber = "5555666677778888",
                            FailedAttempts = 0,
                            IsLocked = false,
                            Pin = "5678",
                            PlaceHolderName = "Jane Smith"
                        },
                        new
                        {
                            Id = new Guid("fa1b4f36-830a-445b-bac8-a455b7d47a15"),
                            AccountId = new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"),
                            CardNumber = "9999000011112222",
                            FailedAttempts = 0,
                            IsLocked = false,
                            Pin = "9876",
                            PlaceHolderName = "Alice Johnson"
                        },
                        new
                        {
                            Id = new Guid("f3b337ad-d825-406a-8bda-7891433f9624"),
                            AccountId = new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"),
                            CardNumber = "3333444455556666",
                            FailedAttempts = 0,
                            IsLocked = false,
                            Pin = "5432",
                            PlaceHolderName = "Bob Brown"
                        },
                        new
                        {
                            Id = new Guid("d298f60a-e835-4869-ab77-5f55f4d90bd1"),
                            AccountId = new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"),
                            CardNumber = "7777888899990000",
                            FailedAttempts = 0,
                            IsLocked = false,
                            Pin = "1111",
                            PlaceHolderName = "Charlie Davis"
                        });
                });

            modelBuilder.Entity("Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Transaction", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("df4fdff9-6086-4ab9-8c74-12ee7c4abebd"),
                            AccountId = new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"),
                            Amount = 100.00m,
                            Date = new DateTime(2024, 8, 24, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9099),
                            Description = "Deposit"
                        },
                        new
                        {
                            Id = new Guid("f6c94311-e10e-4e2b-9bbf-c9f93608c420"),
                            AccountId = new Guid("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"),
                            Amount = 50.00m,
                            Date = new DateTime(2024, 8, 26, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9115),
                            Description = "Withdrawal"
                        },
                        new
                        {
                            Id = new Guid("ba9a2f03-7b93-4ea5-91f8-fb8a7372e395"),
                            AccountId = new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"),
                            Amount = 200.00m,
                            Date = new DateTime(2024, 8, 19, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9131),
                            Description = "Deposit"
                        },
                        new
                        {
                            Id = new Guid("e77754aa-bf57-47e6-b71b-b9c74dc3aad5"),
                            AccountId = new Guid("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"),
                            Amount = 30.00m,
                            Date = new DateTime(2024, 8, 22, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9135),
                            Description = "Withdrawal"
                        },
                        new
                        {
                            Id = new Guid("d87402fb-c955-4687-aa5f-464db6c03280"),
                            AccountId = new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"),
                            Amount = 150.00m,
                            Date = new DateTime(2024, 8, 14, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9138),
                            Description = "Deposit"
                        },
                        new
                        {
                            Id = new Guid("ea272780-5a92-4b35-a1f4-ae1acb3348d1"),
                            AccountId = new Guid("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"),
                            Amount = 75.00m,
                            Date = new DateTime(2024, 8, 17, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9140),
                            Description = "Withdrawal"
                        },
                        new
                        {
                            Id = new Guid("a64a8c70-65b7-44d2-a399-68a75aa306b4"),
                            AccountId = new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"),
                            Amount = 200.00m,
                            Date = new DateTime(2024, 8, 9, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9142),
                            Description = "Deposit"
                        },
                        new
                        {
                            Id = new Guid("c776db29-65a4-4764-9fda-b91424e7bf66"),
                            AccountId = new Guid("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"),
                            Amount = 100.00m,
                            Date = new DateTime(2024, 8, 11, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9144),
                            Description = "Withdrawal"
                        },
                        new
                        {
                            Id = new Guid("9843c13f-e3bf-4bfd-9ab5-070b3b98ce50"),
                            AccountId = new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"),
                            Amount = 250.00m,
                            Date = new DateTime(2024, 8, 4, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9147),
                            Description = "Deposit"
                        },
                        new
                        {
                            Id = new Guid("3046e730-654f-4460-86fe-d59b050a6bbf"),
                            AccountId = new Guid("b1e4f70b-29a2-4d52-99c3-e0c09246d839"),
                            Amount = 125.00m,
                            Date = new DateTime(2024, 8, 7, 13, 47, 25, 142, DateTimeKind.Local).AddTicks(9149),
                            Description = "Withdrawal"
                        });
                });

            modelBuilder.Entity("ChallengeService.Models.Card", b =>
                {
                    b.HasOne("ChallengeService.Models.Account", "Account")
                        .WithMany("Cards")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Transaction", b =>
                {
                    b.HasOne("ChallengeService.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ChallengeService.Models.Account", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
