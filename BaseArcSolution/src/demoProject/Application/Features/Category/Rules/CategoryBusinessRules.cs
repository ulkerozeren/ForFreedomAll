using Application.RepositoryInterfaces;
using Core.Application.Exceptions;
using Domain.Entities;

namespace Application.Features.Category.Rules
{
    public class CategoryBusinessRules
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryBusinessRules(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CategoryNameCanNotBeDuplicatedWhenInserted(string name)
        {
            var result =  _categoryRepository.GetWhere(b => b.Name == name).Result.ToList();
            if (result!=null && result.Count>0) throw new BusinessException("Category name exists.");
        }

        public void CategoryShouldExistWhenRequested(Domain.Entities.Category category)
        {
            if (category == null) throw new BusinessException("Requested category does not exist");
        }
    }
}
