using Application.Common;
using Application.Common.Tools;
using ChallengeService.Models;
using MediatR;
using Persistence;

namespace Application.Queries.Operations
{
    public class GetOperationQueryHandler : IRequestHandler<GetOperationQuery, PagedList<TransactionResponse>>
    {
        private readonly IRepository<Card> _cardRepository;
        private readonly IRepository<Account> _accountRepository;
        private readonly IRepository<Transaction> _transactionRepository;



        public GetOperationQueryHandler(IRepository<Card> cardRepository, IRepository<Account> accountRepository, IRepository<Transaction> transactionRepository)
        {
            _cardRepository = cardRepository;
            _accountRepository = accountRepository;
            _transactionRepository = transactionRepository;

        }

        public async Task<PagedList<TransactionResponse>> Handle(GetOperationQuery request, CancellationToken cancellationToken)
        {

            var cards = await _cardRepository.GetAllAsync(cancellationToken);
            var accounts = await _accountRepository.GetAllAsync(cancellationToken);
            var transactions = await _transactionRepository.GetAllAsync(cancellationToken);

            var result = (from card in cards
                          join account in accounts on card.AccountId equals account.Id
                          join transaction in transactions on account.Id equals transaction.AccountId
                          where card.CardNumber == request.CardNumber
                          select new TransactionResponse
                          {
                              Amount = transaction.Amount,
                              LastWithdrawDate = transaction.Date,
                              ClientName = account.UserName,
                              OperationType = transaction.Description
                          }).ToList();


            return PagedList<TransactionResponse>.CreatePagedList(result, request.PageNumber, request.PageSize);
        }
    }
}
