using CQRSMediatRExample.CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSMediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public ProductController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetByIdProductQueryRequest() { Id = id };
            return Ok(await _mediatR.Send(query));
        }
    }
}
