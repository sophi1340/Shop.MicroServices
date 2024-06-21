﻿namespace Products.Domain.Products
{
    public interface IProductReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Tuple<List<Product>, int>> GetByFilterPagedAsync(ProductFilterPageReqDto request);
        Task<Product> GetAsync(int id);
        Task<Product> GetAsyncNoTracking(int id);
    }
}
