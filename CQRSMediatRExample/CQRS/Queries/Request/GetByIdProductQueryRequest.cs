using CQRSMediatRExample.CQRS.Queries.Response;
using CQRSMediatRExample.Entities;
using MediatR;

namespace CQRSMediatRExample.CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Product ProductId { get; set; }
    }
}
