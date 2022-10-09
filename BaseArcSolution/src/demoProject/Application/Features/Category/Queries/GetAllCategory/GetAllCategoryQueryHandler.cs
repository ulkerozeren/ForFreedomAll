using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Category.Queries.GetAllCategory
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
    {
        readonly ICategoryRepository _categoryRepository;

        public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCategorytCount = _categoryRepository.GetAll(false).Count(); 
            var categories = _categoryRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();

            return new()
            {
                Categories = categories,
                TotalCategoryCount = totalCategorytCount

            };
        }
    }
}