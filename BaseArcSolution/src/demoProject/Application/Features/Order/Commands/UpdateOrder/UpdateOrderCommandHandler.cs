using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Order.Commands.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        readonly IOrderRepository _orderRepository;

        public UpdateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Order order = await _orderRepository.GetByIdAsync(request.Id.ToString());

            await _orderRepository.SaveAsync();

            return new();
        }
    }
}
