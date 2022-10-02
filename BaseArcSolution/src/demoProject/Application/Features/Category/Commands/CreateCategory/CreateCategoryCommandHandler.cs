using Application.Features.Category.Rules;
using Application.RepositoryInterfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Category.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        readonly ICategoryRepository _categoryRepository;
        readonly CategoryBusinessRules _categoryBusinessRules;
        readonly IMapper _mapper;
        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, CategoryBusinessRules categoryBusinessRules, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _categoryBusinessRules = categoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _categoryBusinessRules.CategoryNameCanNotBeDuplicatedWhenInserted(request.Name);

            var entity = _mapper.Map<Domain.Entities.Category>(request);
            await _categoryRepository.AddAsync(entity);
            await _categoryRepository.SaveAsync();



            return new();
        }
    }
}
