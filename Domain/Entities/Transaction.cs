using ChallengeService.Models;

public class Transaction
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public Guid AccountId { get; set; }
    public Account Account { get; set; }
}
