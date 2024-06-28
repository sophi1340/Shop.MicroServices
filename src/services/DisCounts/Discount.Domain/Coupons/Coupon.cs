using Discount.Domain.Base;
using Discount.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Discount.Domain.Coupons
{
    public class Coupon : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public DiscountType DiscountType { get; set; }
        public int Value { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
        {
            public void Configure(EntityTypeBuilder<Coupon> builder)
            {
                builder.HasKey(b => b.Id);
                builder.Property(p => p.ProductId).IsRequired();
                builder.Property(p => p.ProductTitle).IsRequired().HasMaxLength(300).HasColumnType("Nvarchar(300)");
                builder.Property(p => p.DiscountType).IsRequired().HasComment(" Percent = 1,Amount = 2");
                builder.Property(p => p.Value).IsRequired();
                builder.Property(p => p.StartDate).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.EndDate).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.ModificationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
            }
        }
    }
}
