using Discount.Domain.Base;
using Discount.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Discount.Domain.Coupons
{
    public class Coupon : BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [MaxLength(300)]
        public string ProductTitle { get; set; }
        public DiscountType DiscountType { get; set; }
        public int Value { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
