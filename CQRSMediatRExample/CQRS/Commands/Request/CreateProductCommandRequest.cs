using CQRSMediatRExample.CQRS.Commands.Response;
using MediatR;

namespace CQRSMediatRExample.CQRS.Commands.Request
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
