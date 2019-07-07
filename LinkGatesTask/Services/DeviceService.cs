using LinkGatesTask.DTOs;
using LinkGatesTask.Models;
using LinkGatesTask.Repos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LinkGatesTask.Services
{
    public class DeviceService
    {
        private readonly DeviceReposetory deviceReposetory;
        private readonly PropertyValueService propertyValueService;
        public DeviceService(
            DeviceReposetory _deviceReposetory,
            PropertyValueService _propertyValueService
            )
        {
            deviceReposetory = _deviceReposetory;
            propertyValueService = _propertyValueService;
        }

        public async Task AddDevice(DeviceModel device)
        {
            Device newDevice=await deviceReposetory.AddAsync(new Device
            {
                Dev_Name = device.Dev_Name,
                Acquisition_Date = Convert.ToDateTime(device.Acquisition_Date),
                Cati_Id = device.Cati_Id,
                Memo = device.Memo,
                SerialNumber = device.SerialNumber
            });

            await propertyValueService.Add(device.PropertyValues, newDevice.Dev_Id);
        }

        public Device GetDevice(int DeviceID)
        {
            return deviceReposetory
                .Query()
                .Where(a => a.Dev_Id == DeviceID)
                .Include(a => a.Category)
                .Include(a => a.PropertyValues)
                .Include(a => a.PropertyValues.Select(u => u.Property)).FirstOrDefault();
        }

        public IEnumerable<Device> GetAll()
        {
           return deviceReposetory.Query()
                .Include(a => a.Category)
                .Include(a => a.PropertyValues)
                .Include(a=>a.PropertyValues.Select(u=>u.Property))
                .ToList<Device>();
        }

        public async Task UpdateDevice(DeviceModel device)
        {
            await deviceReposetory.UpdateAsync(new Device
            {
                Dev_Id=device.Dev_Id,
                Dev_Name = device.Dev_Name,
                Acquisition_Date = Convert.ToDateTime(device.Acquisition_Date),
                Cati_Id = device.Cati_Id,
                Memo = device.Memo,
                SerialNumber = device.SerialNumber
            });

            await propertyValueService.Update(device.PropertyValues,device.Dev_Id);
        }
    }
}