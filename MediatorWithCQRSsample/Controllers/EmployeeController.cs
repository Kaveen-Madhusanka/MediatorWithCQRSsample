using MediatorWithCQRSsample.Commands;
using MediatorWithCQRSsample.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatorWithCQRSsample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetEmployee/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Response = await _mediator.Send(new GetEmployeeById.Query(id));
            return Response == null ? NotFound() : Ok(Response);
        }
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(AddEmployee.Command command) => Ok(await _mediator.Send(command));
    }
}
