using MediatR;
using Products.Domain.Base;
using Products.Domain.Products;

namespace Products.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : ProductFilterPageReqDto, IRequest<PaginitionResDto<List<ProductResDto>>>
    {

    }
}
