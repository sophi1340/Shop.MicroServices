using Discount.Domain.Coupons;
using MediatR;

namespace Discount.Application.Coupons.Create
{
    public class CreateCouponCommand : CouponDto, IRequest<int>
    {

    }
}
