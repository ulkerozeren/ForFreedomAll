using MediatR;

namespace Application.Features.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
