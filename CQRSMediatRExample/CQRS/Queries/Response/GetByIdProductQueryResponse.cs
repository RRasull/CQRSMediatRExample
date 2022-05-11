namespace CQRSMediatRExample.CQRS.Queries.Response
{
    public class GetByIdProductQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
