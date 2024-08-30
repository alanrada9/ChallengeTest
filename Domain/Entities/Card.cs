namespace ChallengeService.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string CardNumber { get; set; }
        public string PlaceHolderName { get; set; }
        public string Pin { get; set; }
        public bool IsLocked { get; set; }
        public int FailedAttempts { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
    }
}
