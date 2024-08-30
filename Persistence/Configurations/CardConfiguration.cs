using ChallengeService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.ToTable("Card");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        builder.Property(c => c.CardNumber)
            .HasColumnName("CardNumber")
            .IsRequired()
            .HasMaxLength(16);

        builder.Property(c => c.PlaceHolderName)
            .HasColumnName("PlaceHolderName")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Pin)
            .HasColumnName("Pin")
            .IsRequired()
            .HasMaxLength(4);

        builder.Property(c => c.IsLocked)
            .HasColumnName("IsLocked")
            .IsRequired();

        builder.Property(c => c.FailedAttempts)
            .HasColumnName("FailedAttempts")
            .IsRequired();

        builder.HasOne(c => c.Account)
            .WithMany(a => a.Cards)
            .HasForeignKey(c => c.AccountId);

        builder.HasData(
            new Card { Id = Guid.NewGuid(), CardNumber = "1111222233334444", PlaceHolderName = "John Doe", Pin = "1234", IsLocked = false, FailedAttempts = 0, AccountId = Guid.Parse("3d3f5a9d-1e4e-4eae-a1c0-daa84edb50ef") },
            new Card { Id = Guid.NewGuid(), CardNumber = "5555666677778888", PlaceHolderName = "Jane Smith", Pin = "5678", IsLocked = false, FailedAttempts = 0, AccountId = Guid.Parse("6e1b2284-7460-4f5b-8c6b-e6f9d249e7c1") },
            new Card { Id = Guid.NewGuid(), CardNumber = "9999000011112222", PlaceHolderName = "Alice Johnson", Pin = "9876", IsLocked = false, FailedAttempts = 0, AccountId = Guid.Parse("8b8c7b85-11f1-4a6b-9a8b-7b593d7de8c2") },
            new Card { Id = Guid.NewGuid(), CardNumber = "3333444455556666", PlaceHolderName = "Bob Brown", Pin = "5432", IsLocked = false, FailedAttempts = 0, AccountId = Guid.Parse("a0d8e517-5e2c-4ecb-8a3f-5e550c9c485d") },
            new Card { Id = Guid.NewGuid(), CardNumber = "7777888899990000", PlaceHolderName = "Charlie Davis", Pin = "1111", IsLocked = false, FailedAttempts = 0, AccountId = Guid.Parse("b1e4f70b-29a2-4d52-99c3-e0c09246d839") }
        );
    }
}
