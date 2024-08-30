using Application.Queries.Balance;
using Application.Queries.Cards;
using Application.Queries.Operations;
using Application.Queries.Token.GetToken;
using Application.Queries.Withdraws;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            return Ok(await QueryAsync(req));
        }

        [Authorize]
        [HttpGet("Withdraw")]
        public async Task<IActionResult> Withdraw(WithdrawnQuery req)
        {

            return Ok(await QueryAsync(req));
        }
        [Authorize]
        [HttpGet("Operations")]
        public async Task<IActionResult> GetOperationsDetails(GetOperationQuery req)
        {

            return Ok(await QueryAsync(req));
        }
    }
}
