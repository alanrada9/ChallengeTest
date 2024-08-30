using MediatR;

namespace Application.Queries.Cards
{
    public class GetCardsByIdQuery : IRequest<bool>
    {
        public string Pin { get; set; }
        public string CardNumber { get; set; }
    }
}
