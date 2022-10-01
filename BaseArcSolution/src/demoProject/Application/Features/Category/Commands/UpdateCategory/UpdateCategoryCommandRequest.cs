using MediatR;

namespace Application.Features.Category.Commands.UpdateCategory
{ 
    public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
