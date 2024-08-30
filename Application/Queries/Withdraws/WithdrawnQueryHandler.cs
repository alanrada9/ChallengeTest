using Application.Common.Enum;
using Application.Common.Exceptions;
using ChallengeService.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Queries.Withdraws
{
    public class WithdrawnQueryHandler : IRequestHandler<WithdrawnQuery, WithdrawnQueryResponse>
    {
        private readonly IRepository<Card> _cardRepository;
        private readonly IRepository<Transaction> _transactionRepository;

        public WithdrawnQueryHandler(IRepository<Card> cardRepository, IRepository<Transaction> transactionRepository)
        {
            _cardRepository = cardRepository;
            _transactionRepository = transactionRepository;
        }

        public async Task<WithdrawnQueryResponse> Handle(WithdrawnQuery request, CancellationToken cancellationToken)
        {
            var card = await _cardRepository.FirstOrDefaultAsync(
               c => c.CardNumber == request.CardNumber,
               query => query.Include(c => c.Account),
               cancellationToken
           );

            if (card == null)
            {
                throw new ArgumentException("Card not found.");
            }

            if (card.Account.Balance < request.Amount)
            {
                throw new NotEnoughFundsException($"Insufficient funds: Current balance is {card.Account.Balance} but attempted withdrawal is {request.Amount}");
            }

            if (request.Amount <= 0)
            {
                throw new ArgumentException("The withdrawal amount must be greater than zero.");
            }

            card.Account.Balance -= request.Amount;

            var transaction = new Transaction
            {
                Date = DateTime.UtcNow,
                Amount = request.Amount,
                Description = OperationType.Deposit.ToString(),
                AccountId = card.AccountId
            };

            await _cardRepository.UpdateAsync(card, cancellationToken);
            await _transactionRepository.AddAsync(transaction, cancellationToken);
            await _transactionRepository.SaveChangesAsync(cancellationToken);

            return new WithdrawnQueryResponse
            {
                OperationDate = DateTime.UtcNow,
                Amount = request.Amount,
                CurrentBalance = card.Account.Balance
            };
        }
    }
}