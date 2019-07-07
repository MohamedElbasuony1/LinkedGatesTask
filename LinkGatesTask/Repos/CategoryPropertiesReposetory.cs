using LinkGatesTask.Contracts;
using LinkGatesTask.DAL;
using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Repos
{
    public class CategoryPropertiesReposetory : Reposetory<CategoryProperties>, ICategoryPropertiesReposetory
    {
        public CategoryPropertiesReposetory(IUnitOfWork unitOfWork, MyContext context)
           : base(context, unitOfWork)
        {
        }
    }
}