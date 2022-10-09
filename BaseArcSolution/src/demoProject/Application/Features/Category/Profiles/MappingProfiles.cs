using Application.Features.Category.Commands.CreateCategory;
using AutoMapper;

namespace Application.Features.Category.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap <Domain.Entities.Category, CreateCategoryCommandRequest>().ReverseMap();
            CreateMap<Domain.Entities.Category, CreateCategoryCommandRequest>().ReverseMap();

        }
    }
}
