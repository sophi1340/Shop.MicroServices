﻿using Microsoft.EntityFrameworkCore;
using Products.Domain.Categories;
using Products.Domain.Products;

namespace Products.Infrastructure
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Order is important. Because first we have insert into Category and then use categoryId when inserting Product
            modelBuilder.ApplyConfiguration(new Category.CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new Product.ProductConfiguration());
        }
    }
}
