using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Category.Commands.DeleteCategory
{
     public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {
        readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }

        public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _categoryRepository.RemoveAsync(request.Id.ToString());
            await _categoryRepository.SaveAsync();
            return new();
        }
    }
}
