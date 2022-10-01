using MediatR;

namespace Application.Features.Category.Queries.GetByIdCategory
{
    public class GetByIdCategoryQueryRequest : IRequest<GetByIdCategoryQueryResponse>
    {
        public string Id { get; set; }
    }
}
