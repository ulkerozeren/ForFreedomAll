using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            await _orderRepository.AddAsync(new()
            {
                  Description=request.Description,
                   Address=request.Address
            });
            await _orderRepository.SaveAsync();

            return new();
        }
    }
}
