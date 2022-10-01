using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Product.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _productRepository.AddAsync(new()
            {
                 Stock= request.Stock,
                  Price= request.Price, 
                   Name= request.Name
            });
            await _productRepository.SaveAsync();

            return new();
        }
    }
}
