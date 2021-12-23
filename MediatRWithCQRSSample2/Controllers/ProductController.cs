using MediatR;
using MediatRWithCQRSSample2.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatRWithCQRSSample2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet("Get")]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _mediator.Send(new GetProductsQuery()));
        //}    

        [HttpGet("Get")]
        public async Task<IActionResult> Get()=> Ok(await _mediator.Send(new GetProductsQuery()));
    }
}
