using Application.RepositoryInterfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        readonly IOrderRepository _orderRepository;
        readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Domain.Entities.Order>(request);

            await _orderRepository.AddAsync(entity);
            await _orderRepository.SaveAsync();

            return new();
        }
    }
}
