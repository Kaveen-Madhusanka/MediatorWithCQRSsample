using MediatorWithCQRSsample.Data;
using MediatorWithCQRSsample.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorWithCQRSsample.Commands
{
    public static class AddEmployee
    {
        public record Command(Employee employee):IRequest<bool>;

        public class Handler : IRequestHandler<Command, bool>
        {
            private readonly AppDbContext _appDbContext;

            public Handler(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }
            public async Task<bool> Handle(Command request, CancellationToken cancellationToken)
            {
                await _appDbContext.Employee.AddAsync(request.employee);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
        }
    }
}
