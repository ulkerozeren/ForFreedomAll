
namespace Application.Features.Product.Queries.GetAllProduct
{ 
    public class GetAllProductQueryResponse
    {
        public int TotalProductCount { get; set; }
        public object Products { get; set; }
    }
}