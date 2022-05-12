using CQRSMediatRExample.CQRS.Commands.Request;
using CQRSMediatRExample.CQRS.Commands.Response;
using CQRSMediatRExample.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatRExample.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        private readonly AppDbContext _context;


        public DeleteProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteProduct = await _context.Products.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if(deleteProduct is null)
            {
                throw new Exception("Product is Not Found");
            }
            _context.Products.Remove(deleteProduct);
            await _context.SaveChangesAsync();
            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
