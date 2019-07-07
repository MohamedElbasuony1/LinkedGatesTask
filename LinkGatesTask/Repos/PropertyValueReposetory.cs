using LinkGatesTask.Contracts;
using LinkGatesTask.DAL;
using LinkGatesTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Repos
{
    public class PropertyValueReposetory: Reposetory<PropertyValue>,IPropertyValueReposetory
    {
        public PropertyValueReposetory(IUnitOfWork unitOfWork, MyContext context)
          : base(context, unitOfWork)
        { }
    }
}