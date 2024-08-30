using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transaction");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Amount)
            .HasColumnName("Amount")
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(t => t.Date)
            .HasColumnName("Date")
            .IsRequired();

        builder.Property(t => t.Description)
            .HasColumnName("Description")
            .HasMaxLength(500);

        builder.HasOne(t => t.Account)
            .WithMany(a => a.Transactions)
            .HasForeignKey(t => t.AccountId);

        builder.HasData(
            new Transaction { Id = Guid.NewGuid(), Amount = 100.00m, Date = DateTime.Now.AddDays(-5), Description = "Deposit", AccountId = Guid.Parse("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef") },
            new Transaction { Id = Guid.NewGuid(), Amount = 50.00m, Date = DateTime.Now.AddDays(-3), Description = "Withdrawal", AccountId = Guid.Parse("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef") },
            new Transaction { Id = Guid.NewGuid(), Amount = 200.00m, Date = DateTime.Now.AddDays(-10), Description = "Deposit", AccountId = Guid.Parse("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1") },
            new Transaction { Id = Guid.NewGuid(), Amount = 30.00m, Date = DateTime.Now.AddDays(-7), Description = "Withdrawal", AccountId = Guid.Parse("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1") },
            new Transaction { Id = Guid.NewGuid(), Amount = 150.00m, Date = DateTime.Now.AddDays(-15), Description = "Deposit", AccountId = Guid.Parse("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2") },
            new Transaction { Id = Guid.NewGuid(), Amount = 75.00m, Date = DateTime.Now.AddDays(-12), Description = "Withdrawal", AccountId = Guid.Parse("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2") },
            new Transaction { Id = Guid.NewGuid(), Amount = 200.00m, Date = DateTime.Now.AddDays(-20), Description = "Deposit", AccountId = Guid.Parse("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d") },
            new Transaction { Id = Guid.NewGuid(), Amount = 100.00m, Date = DateTime.Now.AddDays(-18), Description = "Withdrawal", AccountId = Guid.Parse("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d") },
            new Transaction { Id = Guid.NewGuid(), Amount = 250.00m, Date = DateTime.Now.AddDays(-25), Description = "Deposit", AccountId = Guid.Parse("b1e4f70b-29a2-4d52-99c3-e0c09246d839") },
            new Transaction { Id = Guid.NewGuid(), Amount = 125.00m, Date = DateTime.Now.AddDays(-22), Description = "Withdrawal", AccountId = Guid.Parse("b1e4f70b-29a2-4d52-99c3-e0c09246d839") }
        );
    }
}