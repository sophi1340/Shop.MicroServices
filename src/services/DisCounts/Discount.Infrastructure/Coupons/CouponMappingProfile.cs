using AutoMapper;
using Discount.Domain.Coupons;

namespace Discount.Infrastructure.Coupons
{
    public class CouponMappingProfile : Profile
    {

        public CouponMappingProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
