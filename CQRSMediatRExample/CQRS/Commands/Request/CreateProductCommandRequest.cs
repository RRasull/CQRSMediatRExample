namespace CQRSMediatRExample.CQRS.Commands.Request
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
