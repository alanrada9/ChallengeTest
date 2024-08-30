namespace Application.Queries.Withdraws
{
    public class WithdrawnQueryResponse
    {
        public decimal CurrentBalance { get; set; }
        public decimal Amount { get; set; }
        public DateTime OperationDate { get; set; }

    }
}