using MediatR;
using MediatRWithCQRSSample2.Model;
using System.Collections.Generic;

namespace MediatRWithCQRSSample2.Queries
{
    public record GetProductsQuery : IRequest<List<Product>>;
}
