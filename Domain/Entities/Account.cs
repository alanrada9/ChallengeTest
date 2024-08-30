namespace ChallengeService.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime? LastWithdrawalDate { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}