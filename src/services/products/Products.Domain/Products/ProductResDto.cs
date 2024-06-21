﻿using Products.Domain.Base;

namespace Products.Domain.Products
{
    public class ProductResDto : ProductDto
    {
        public int CategoryId { get; set; }
        public string CategoryTitle_Id { get; set; }
        public string CategoryTitle { get; set; }

    }
    public class ProductReqDto : ProductDto
    {

        public int CategoryId { get; set; }

    }

    public class ProductDto : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Permalink { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
    }
    public class ProductFilterPageReqDto
    {
        public int Id { get; set; }
        public string SearchTerm { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int CategoryId { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }


    }
}
