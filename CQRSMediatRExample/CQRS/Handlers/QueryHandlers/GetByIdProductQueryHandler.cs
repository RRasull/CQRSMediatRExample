using CQRSMediatRExample.CQRS.Queries.Request;
using CQRSMediatRExample.CQRS.Queries.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatRExample.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
