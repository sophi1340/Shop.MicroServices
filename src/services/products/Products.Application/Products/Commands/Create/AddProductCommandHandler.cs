using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Products.Domain;
using Products.Domain.Products;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductResDto>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public async Task<ProductResDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = _mapper.Map<Product>(request);
            var addProduct = await _writeUnitOfWork.ProductWriteRepository.AddAsync(newProduct);
            _logger.LogInformation($"Product {newProduct.Id} Is Successfully Created.");
            return _mapper.Map<ProductResDto>(addProduct);
        }
    }
}
