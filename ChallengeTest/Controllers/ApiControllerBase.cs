using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[Produces("application/json")]
public class ApiControllerBase : ControllerBase
{
    private readonly IMediator _mediator;

    public ApiControllerBase(IMediator mediator)
    {
        _mediator = mediator;
    }
    protected async Task<TResult> QueryAsync<TResult>(IRequest<TResult> query)
    {
        return await _mediator.Send(query);
    }
}