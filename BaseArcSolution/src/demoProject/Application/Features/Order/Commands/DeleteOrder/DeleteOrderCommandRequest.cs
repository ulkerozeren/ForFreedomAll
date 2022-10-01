using MediatR;

namespace Application.Features.Order.Commands.DeleteOrder
{
    public class DeleteOrderCommandRequest : IRequest<DeleteOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
