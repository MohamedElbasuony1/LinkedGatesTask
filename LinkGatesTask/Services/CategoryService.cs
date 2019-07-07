using LinkGatesTask.Models;
using LinkGatesTask.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LinkGatesTask.Services
{
    public class CategoryService
    {
        private readonly CategoryReposatory categoryReposetory;
        public CategoryService(CategoryReposatory _categoryReposatory)
        {
            categoryReposetory = _categoryReposatory;
        }

        public async Task<List<Category>> GetCategories()
        {
            return (await categoryReposetory.GetAllAsync()).ToList<Category>();
        }
    }
}