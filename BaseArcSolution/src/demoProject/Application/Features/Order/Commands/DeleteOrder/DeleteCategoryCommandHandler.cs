using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Order.Commands.DeleteOrder
{ 
   public class DeleteCategoryCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
    {
        readonly IOrderRepository _orderRepository;

        public DeleteCategoryCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }

        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            await _orderRepository.RemoveAsync(request.Id.ToString());
            await _orderRepository.SaveAsync();

            return new();
        }
    }
}
