using Application.Features.Category.Rules;
using Application.RepositoryInterfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Category.Queries.GetByIdCategory
{
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
    {
        readonly ICategoryRepository _categoryRepository;
        readonly CategoryBusinessRules _categoryBusinessRules;
        readonly IMapper _mapper;
        public GetByIdCategoryQueryHandler(ICategoryRepository categoryRepository, CategoryBusinessRules categoryBusinessRules, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _categoryBusinessRules= categoryBusinessRules;  
            _mapper = mapper;
        }

        public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id, false);
            _categoryBusinessRules.CategoryShouldExistWhenRequested(category);

            return _mapper.Map<GetByIdCategoryQueryResponse>(category);

        }
    }
}
