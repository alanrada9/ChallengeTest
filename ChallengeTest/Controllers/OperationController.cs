using Application.Queries.Balance;
using Application.Queries.Cards;
using Application.Queries.Operations;
using Application.Queries.Token.GetToken;
using Application.Queries.Withdraws;
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
        public async Task<IActionResult> GetToken(GetTokenQuery req)
        {
            var isValid = await QueryAsync(new GetCardsByIdQuery()
            {
                CardNumber = req.CardNumber,
                Pin = req.Pin,
            });

            if (isValid)
            {
                return Ok(await QueryAsync(req));
            }

            return Unauthorized();
        }
        [Authorize]
        [HttpGet("balance")]
        public async Task<IActionResult> GetBalance(GetBalanceByCardNumberQuery req)
        {
            var result = await QueryAsync(req);

            if (result!=null)
            {
                await QueryAsync(req);
            }
            return NoContent();

        }

        [Authorize]
        [HttpGet("withdraw")]
        public async Task<IActionResult> Withdraw(WithdrawnQuery req)
        {
            var result = await QueryAsync(req);

            if (result != null)
            {
                await QueryAsync(req);
            }
            return NoContent();
        }
        [Authorize]
        [HttpGet("operations")]
        public async Task<IActionResult> GetOperationsDetails(GetOperationQuery req)
        {

            var result = await QueryAsync(req);

            if (result != null)
            {
                await QueryAsync(req);
            }
            return NoContent();
        }
    }
}
