using Products.Domain;
using Products.Domain.Products;
using Products.Infrastructure.Products;

namespace Products.Infrastructure
{
    public class ReadUnitOfWork : IReadUnitOfWork
    {
        private readonly ProductDbContext _context;

        public ReadUnitOfWork(ProductDbContext context)
        {
            _context = context;
        }

        private ProductReadRepository _productReadRepository;

        public IProductReadRepository ProductReadRepository
        {
            get
            {
                return _productReadRepository ??= new ProductReadRepository(_context);
            }
        }
    }
}
