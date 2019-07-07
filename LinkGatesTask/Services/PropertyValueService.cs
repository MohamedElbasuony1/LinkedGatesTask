using LinkGatesTask.DTOs;
using LinkGatesTask.Models;
using LinkGatesTask.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LinkGatesTask.Services
{
    public class PropertyValueService
    {
        private readonly PropertyValueReposetory propertyValueReposetory;
        public PropertyValueService(PropertyValueReposetory _propertyValueReposetory)
        {
            propertyValueReposetory = _propertyValueReposetory;
        }

        public async Task Add(List<PropertyValueModel> PropertyValues,int DeviceId)
        {
            foreach (var item in PropertyValues)
            {
                await propertyValueReposetory
                    .AddAsync(new PropertyValue
                    {
                        Dev_Id = DeviceId,
                        Prop_Id = item.Prop_Id,
                        Value = item.Value
                    });
            }
        }

        public async Task Update(List<PropertyValueModel> propertyValues, int DeviceId)
        {
            List<PropertyValue> oldpropertyValues=(await propertyValueReposetory
                                                        .FindAllAsync(a => a.Dev_Id == DeviceId))
                                                        .ToList<PropertyValue>();
            foreach (var item in oldpropertyValues)
            {
                await propertyValueReposetory.DeleteAsync(item);
            }

            await Add(propertyValues, DeviceId);
        }
    }
}