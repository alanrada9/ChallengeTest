using ChallengeService.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Queries.Balance
{
    public class GetBalanceByCardNumberQueryHandler : IRequestHandler<GetBalanceByCardNumberQuery, BalanceResponse>
    {
        private readonly IRepository<Card> _cardRepository;

        public GetBalanceByCardNumberQueryHandler(IRepository<Card> cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<BalanceResponse> Handle(GetBalanceByCardNumberQuery request, CancellationToken cancellationToken)
        {
            var response = new BalanceResponse();

            var card = await _cardRepository.FirstOrDefaultAsync(
               c => c.CardNumber == request.CardNumber,
               query => query.Include(c => c.Account),
               cancellationToken
           );

            if (card != null)
            {
                if (card.Account != null)
                {
                    response.UserName = card.PlaceHolderName;
                    response.AccountNumber = card.Account.AccountNumber;
                    response.CurrentBalance = card.Account.Balance;
                    response.LastWithdrawalDate = card.Account.LastWithdrawalDate;
                }
            }

            return response;
        }
    }
}