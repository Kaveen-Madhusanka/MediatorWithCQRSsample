using MediatR;
using MediatRWithCQRSSample2.Data;
using MediatRWithCQRSSample2.Model;
using MediatRWithCQRSSample2.Queries;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRWithCQRSSample2.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<Product>>
    {
        private readonly AppDbContext _appDbContext;

        public GetProductsHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            //return await _appDbContext.products.ToListAsync();
            return await Task.FromResult(_appDbContext.products.ToList());
        }
    }
}
