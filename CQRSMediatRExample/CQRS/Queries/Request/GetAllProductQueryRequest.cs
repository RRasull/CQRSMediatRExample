using CQRSMediatRExample.CQRS.Queries.Response;
using MediatR;
using System.Collections.Generic;

namespace CQRSMediatRExample.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {

    }
}
