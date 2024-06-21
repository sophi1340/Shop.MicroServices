using MediatR;
using Products.Domain.Products;

namespace Products.Application.Products.Commands.Update
{
    public class UpdateProductCommand : ProductReqDto, IRequest<bool>
    {

    }
}
