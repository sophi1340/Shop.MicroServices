using AutoMapper;
using Products.Domain.Products;

namespace Products.Infrastructure.Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductReqDto>().ReverseMap();
            CreateMap<Product, ProductResDto>().ForMember(dest => dest.CategoryTitle_Id,
                config =>
                    config.MapFrom(src => $"{src.Category.Title}({src.CategoryId})")).ReverseMap();
        }
    }
}
