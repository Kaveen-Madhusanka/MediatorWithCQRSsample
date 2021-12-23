using MediatR;
using MediatRWithCQRSSample2.Command;
using MediatRWithCQRSSample2.Data;
using MediatRWithCQRSSample2.Model;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRWithCQRSSample2.Handlers
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Product>
    {
        private readonly AppDbContext _appDbContext;

        public InsertProductHandler(AppDbContext appDbContext)
        {
           _appDbContext = appDbContext;
        }
        public async Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            _appDbContext.products.Add(request.product);
            _appDbContext.SaveChanges();    
            return await Task.FromResult(request.product);
        }
    }
}
