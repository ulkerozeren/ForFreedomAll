using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Product.Commands.DeleteProduct
{ 
   public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _productRepository.RemoveAsync(request.Id.ToString());
            await _productRepository.SaveAsync();

            return new();
        }
    }
}
