using MediatR;
using MediatRWithCQRSSample2.Model;

namespace MediatRWithCQRSSample2.Command
{
    public record InsertProductCommand(Product product):IRequest<Product>;
}
