using CQRSMediatRExample.CQRS.Queries.Request;
using CQRSMediatRExample.CQRS.Queries.Response;
using CQRSMediatRExample.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatRExample.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private readonly AppDbContext _context;


        public GetAllProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.ToListAsync();
            List<GetAllProductQueryResponse> productsResponse = new List<GetAllProductQueryResponse>();

            foreach (var item in products)
            {
                var model = new GetAllProductQueryResponse()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price
                };
                productsResponse.Add(model);
            }

            return productsResponse;
        }
    }
}
