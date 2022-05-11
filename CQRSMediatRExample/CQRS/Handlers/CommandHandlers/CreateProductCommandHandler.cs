using CQRSMediatRExample.CQRS.Commands.Request;
using CQRSMediatRExample.CQRS.Commands.Response;
using CQRSMediatRExample.DAL;
using CQRSMediatRExample.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatRExample.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly AppDbContext _context;


        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
           var product = await _context.Products.AddAsync(new Product
            {
                Name = request.Name,
                Price = request.Price
            });
            await _context.SaveChangesAsync();
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = product.Entity.Id
            };
        }
    }
}
