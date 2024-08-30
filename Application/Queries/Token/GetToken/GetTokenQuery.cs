using MediatR;

namespace Application.Queries.Token.GetToken
{
    public class GetTokenQuery : IRequest<TokenResponseDto>
    {
        public string Pin { get; set; }
        public string CardNumber { get; set; }
    }
}
