using Discount.Domain.Coupons;
using Microsoft.EntityFrameworkCore;

namespace Discount.Infrastructure
{
    public class DiscountDbContext : DbContext
    {
        public DiscountDbContext(DbContextOptions<DiscountDbContext> options) : base(options)
        {
        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Coupon.CouponConfiguration());
        }
    }
}
