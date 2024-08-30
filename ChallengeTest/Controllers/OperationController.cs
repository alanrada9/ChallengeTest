using Application.Common.Exceptions;
using Application.Common.Tools;
using Application.Queries.Balance;
using Application.Queries.Cards;
using Application.Queries.Operations;
using Application.Queries.Token.GetToken;
using Application.Queries.Withdraws;
using ChallengeTest.Model;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ChallengeTest.Controllers
{
    public class OperationController : ApiControllerBase
    {
        public OperationController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("login")]
        public async Task<Result<TokenResponseDto>> GetToken(GetTokenQuery req)
        {
            var isValid = await QueryAsync(new GetCardsByIdQuery()
            {
                CardNumber = req.CardNumber,
                Pin = req.Pin,
            });

            if (isValid)
            {
                Result<TokenResponseDto> result = await QueryAsync(req);

                return result;
            }
            return null;
        }
        [Authorize]
        [HttpGet("balance")]
        public async Task<Result<BalanceResponse>> GetBalance(GetBalanceByCardNumberQuery req)
        {
            Result<BalanceResponse> result = await QueryAsync(req);

            return result;
        }

        [Authorize]
        [HttpGet("withdraw")]
        public async Task<Result<WithdrawnQueryResponse>> Withdraw(WithdrawnQuery req)
        {
            Result<WithdrawnQueryResponse> result = await QueryAsync(req);

            return result;
        }
        [Authorize]
        [HttpGet("operations")]
        public async Task<Result<PagedList<TransactionResponse>>> GetOperationsDetails(GetOperationQuery req)
        {
            Result<PagedList<TransactionResponse>> result = await QueryAsync(req);

            return result;
        }
    }
}
