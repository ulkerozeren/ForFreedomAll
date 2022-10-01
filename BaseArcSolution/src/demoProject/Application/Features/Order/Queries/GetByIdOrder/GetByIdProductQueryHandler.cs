using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Order.Queries.GetByIdOrder
{
    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQueryRequest, GetByIdOrderQueryResponse>
    {
        readonly IOrderRepository _orderRepository;
        public GetByIdOrderQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<GetByIdOrderQueryResponse> Handle(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Description = order.Description,
                Address = order.Address
            };
        }
    }
}
