using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        readonly ICategoryRepository _categoryRepository;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Category category = await _categoryRepository.GetByIdAsync(request.Id.ToString());

            await _categoryRepository.SaveAsync();

            return new();
        }
    }
}
