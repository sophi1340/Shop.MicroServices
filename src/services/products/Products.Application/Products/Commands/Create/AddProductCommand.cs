using MediatR;
using Products.Domain.Products;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommand : ProductReqDto, IRequest<ProductResDto>
    {
    }
}
