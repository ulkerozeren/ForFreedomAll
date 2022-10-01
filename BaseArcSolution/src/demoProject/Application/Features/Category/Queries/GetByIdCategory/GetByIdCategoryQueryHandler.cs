using Application.Features.Category.Rules;
using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Category.Queries.GetByIdCategory
{
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
    {
        readonly ICategoryRepository _categoryRepository;
        readonly CategoryBusinessRules _categoryBusinessRules;

        public GetByIdCategoryQueryHandler(ICategoryRepository categoryRepository, CategoryBusinessRules categoryBusinessRules)
        {
            _categoryRepository = categoryRepository;
            _categoryBusinessRules= categoryBusinessRules;  
        }

        public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id, false);

            _categoryBusinessRules.CategoryShouldExistWhenRequested(category);

            return new()
            {
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}
