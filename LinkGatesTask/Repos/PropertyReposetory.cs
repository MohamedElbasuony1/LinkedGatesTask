using LinkGatesTask.Contracts;
using LinkGatesTask.DAL;
using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Repos
{
    public class PropertyReposetory: Reposetory<Property>,IPropertyReposetory
    {
        public PropertyReposetory(IUnitOfWork unitOfWork,MyContext context)
            :base(context, unitOfWork)
        {
        }
    }
}