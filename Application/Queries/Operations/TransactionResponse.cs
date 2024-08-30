namespace Application.Queries.Operations
{
    public class TransactionResponse
    {
        public string ClientName { get; set; }
        public DateTime LastWithdrawDate { get; set; }
        public decimal Amount { get; set; }
        public string OperationType { get; set; }
    }
}
