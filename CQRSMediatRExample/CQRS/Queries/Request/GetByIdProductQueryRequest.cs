using CQRSMediatRExample.CQRS.Queries.Response;
using MediatR;

namespace CQRSMediatRExample.CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
}
