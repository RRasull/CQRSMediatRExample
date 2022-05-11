using CQRSMediatRExample.CQRS.Commands.Response;
using MediatR;

namespace CQRSMediatRExample.CQRS.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public int Id { get; set; }

    }
}
