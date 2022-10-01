using Application.RepositoryInterfaces;
using MediatR;

namespace Application.Features.Order.Queries.GetAllOrder
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQueryRequest, GetAllOrderQueryResponse>
    {
        readonly IOrderRepository _orderRepository;

        public GetAllOrderQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<GetAllOrderQueryResponse> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var totalOrderCount = _orderRepository.GetAll(false).Count();
            var orders = _orderRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).ToList();             

            return new()
            {
                Orders = orders,
                TotalOrderCount = totalOrderCount
            };
        }
    }
}