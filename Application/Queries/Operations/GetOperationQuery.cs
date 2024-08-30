using Application.Common.Tools;
using MediatR;

namespace Application.Queries.Operations
{
    public class GetOperationQuery : IRequest<PagedList<TransactionResponse>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string CardNumber { get; set; }
    }
}
