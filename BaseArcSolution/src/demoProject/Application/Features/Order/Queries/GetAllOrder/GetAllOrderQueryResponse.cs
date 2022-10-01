
namespace Application.Features.Order.Queries.GetAllOrder
{ 
    public class GetAllOrderQueryResponse
    {
        public int TotalOrderCount { get; set; }
        public object Orders { get; set; }
    }
}