using Application.Features.Category.Rules;
using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Category.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        readonly ICategoryRepository _categoryRepository;
        readonly CategoryBusinessRules _categoryBusinessRules;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, CategoryBusinessRules categoryBusinessRules)
        {
            _categoryRepository = categoryRepository;
            _categoryBusinessRules = categoryBusinessRules;

        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _categoryBusinessRules.CategoryNameCanNotBeDuplicatedWhenInserted(request.Name);

            await _categoryRepository.AddAsync(new()
            {
                Name = request.Name
            });
            await _categoryRepository.SaveAsync();

            return new();
        }
    }
}
