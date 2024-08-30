namespace Application.Queries.Balance
{
    public class BalanceResponse
    {
        public string UserName { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public DateTime? LastWithdrawalDate { get; set; }
    }
}