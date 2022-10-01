using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Product.Queries.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IProductRepository _productRepository;

        public GetAllProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var totalProductCount =  _productRepository.GetAll(false).Count();

            var products = _productRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();             

            return new()
            {
                Products = products,
                TotalProductCount = totalProductCount
            };
        }
    }
}