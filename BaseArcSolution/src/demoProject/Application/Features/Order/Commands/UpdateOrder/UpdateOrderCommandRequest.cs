using MediatR;

namespace Application.Features.Order.Commands.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
