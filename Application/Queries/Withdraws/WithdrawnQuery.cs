using MediatR;

namespace Application.Queries.Withdraws
{
    public class WithdrawnQuery : IRequest<WithdrawnQueryResponse>
    {
        public string CardNumber { get; set; }

        public decimal Amount { get; set; }
    }
}
