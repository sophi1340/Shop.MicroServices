using Products.Domain.Base;
using Products.Domain.Categories;

namespace Products.Domain.Products
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Permalink { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
