using MediatorWithCQRSsample.Data;
using MediatorWithCQRSsample.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorWithCQRSsample.Queries
{
    public static class GetEmployeeById
    {
       
        // Query -data
        public record Query(int id):IRequest<Response>;
        //like
        //public class Query
        //{
        //    public int Id { get;  }
        //}
        public class Handler : IRequestHandler<Query ,Response>
        {
            private readonly AppDbContext _appDbContext;
            public Handler(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }
            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                var Emp = await _appDbContext.Employee.FirstOrDefaultAsync<Employee>(x => x.Id == request.id);
                return Emp == null ? null : new Response(Emp);  
            }
        }
        // Handler - BL
        public record Response(Employee employee);

    }
}
