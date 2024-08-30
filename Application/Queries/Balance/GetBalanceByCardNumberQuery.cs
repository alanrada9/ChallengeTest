using MediatR;

namespace Application.Queries.Balance
{
    public class GetBalanceByCardNumberQuery : IRequest<BalanceResponse>
    { 
        public string CardNumber { get; set; }
    }
}