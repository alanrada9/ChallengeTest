using Application.Common.Exceptions;
using ChallengeService.Models;
using MediatR;
using Persistence;

namespace Application.Queries.Cards
{
    public class GetCardsByIdQueryHandler : IRequestHandler<GetCardsByIdQuery, bool>
    {
        private readonly IRepository<Card> _cardRepository;

        public GetCardsByIdQueryHandler(IRepository<Card> cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<bool> Handle(GetCardsByIdQuery request, CancellationToken cancellationToken)
        {
            var card = await _cardRepository.FirstOrDefaultAsync(c => c.CardNumber == request.CardNumber, cancellationToken);

            if (card == null || card.IsLocked)
            {
                return false;
            }

            if (card.Pin != request.Pin)
            {
                card.FailedAttempts++;

                if (card.FailedAttempts >= 4)
                {
                    card.IsLocked = true;
                    throw new CardBlockedException($"The card is blocked.Retries count: {card.FailedAttempts}.");
                }

                await _cardRepository.UpdateAsync(card, cancellationToken);
                await _cardRepository.SaveChangesAsync(cancellationToken);

                return false;
            }

            return true;
        }
    }
}