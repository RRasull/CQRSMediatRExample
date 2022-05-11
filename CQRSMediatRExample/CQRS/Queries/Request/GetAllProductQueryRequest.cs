using CQRSMediatRExample.CQRS.Queries.Response;
using MediatR;

namespace CQRSMediatRExample.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<GetAllProductQueryResponse>
    {

    }
}
