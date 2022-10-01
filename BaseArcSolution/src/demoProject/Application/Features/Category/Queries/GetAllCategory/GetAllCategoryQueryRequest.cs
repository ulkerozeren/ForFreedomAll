using MediatR;


namespace Application.Features.Category.Queries.GetAllCategory
{ 
    public class GetAllCategoryQueryRequest : IRequest<GetAllCategoryQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}