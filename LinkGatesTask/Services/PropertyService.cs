using LinkGatesTask.DTOs;
using LinkGatesTask.Models;
using LinkGatesTask.Repos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Services
{
    public class PropertyService
    {
        private readonly CategoryPropertiesReposetory categoryPropertiesReposetory;
        public PropertyService(CategoryPropertiesReposetory _categoryPropertiesReposetory)
        {
            categoryPropertiesReposetory = _categoryPropertiesReposetory;
        }

        public List<PropertyValueModel> GetPropertiesByCategory(int CategoryID)
        {
            return categoryPropertiesReposetory
                .Query()
                .Include(a => a.Property)
                .Where(a => a.Cati_Id == CategoryID)
                .Select(a => new PropertyValueModel
                {
                    Prop_Id = a.Prop_Id,
                    Description = a.Property.Description
                }).ToList<PropertyValueModel>();
        }

    }
}