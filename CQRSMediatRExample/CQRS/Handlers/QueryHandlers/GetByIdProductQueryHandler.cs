using CQRSMediatRExample.CQRS.Queries.Request;
using CQRSMediatRExample.CQRS.Queries.Response;
using CQRSMediatRExample.DAL;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatRExample.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {

        private readonly AppDbContext _context;


        public GetByIdProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _context.Products.Where(x => x.Id == request.Id).FirstOrDefault();
            if (product is null)
            {
                throw new Exception("Product is Not Found");
            }
            var response = new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };

            return Task.FromResult(response);
        }
    }
}
