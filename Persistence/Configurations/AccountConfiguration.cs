using ChallengeService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Account");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(a => a.UserName)
            .HasColumnName("UserName")
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(a => a.AccountNumber)
            .HasColumnName("AccountNumber")
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(a => a.Balance)
            .HasColumnName("Balance")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(a => a.LastWithdrawalDate)
            .HasColumnName("LastWithdrawalDate")
            .IsRequired();

        builder.HasMany(a => a.Transactions)
            .WithOne(t => t.Account)
            .HasForeignKey(t => t.AccountId);

        builder.HasMany(a => a.Cards)
            .WithOne(c => c.Account)
            .HasForeignKey(c => c.AccountId);

        builder.HasData(
            new Account { Id = Guid.Parse("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef"), UserName = "John Doe", AccountNumber = "ACC123456789", Balance = 1000.00m, LastWithdrawalDate = DateTime.Now },
            new Account { Id = Guid.Parse("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1"), UserName = "Jane Smith", AccountNumber = "ACC987654321", Balance = 2000.00m, LastWithdrawalDate = DateTime.Now },
            new Account { Id = Guid.Parse("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2"), UserName = "Alice Johnson", AccountNumber = "ACC112233445", Balance = 1500.00m, LastWithdrawalDate = DateTime.Now },
            new Account { Id = Guid.Parse("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d"), UserName = "Bob Brown", AccountNumber = "ACC556677889", Balance = 500.00m, LastWithdrawalDate = DateTime.Now },
            new Account { Id = Guid.Parse("b1e4f70b-29a2-4d52-99c3-e0c09246d839"), UserName = "Charlie Davis", AccountNumber = "ACC998877665", Balance = 750.00m, LastWithdrawalDate = DateTime.Now }
        );
    }
}
