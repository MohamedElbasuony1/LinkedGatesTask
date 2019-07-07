using LinkGatesTask.DTOs;
using LinkGatesTask.Models;
using LinkGatesTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LinkGatesTask.Controllers
{
    public class DeviceController : Controller
    {
        private readonly DeviceService deviceService;
        private readonly CategoryService categoryService;
        private readonly PropertyService propertyService;
        public DeviceController(DeviceService _deviceService,
                                CategoryService _categoryService,
                                PropertyService _propertyService)
        {
            deviceService = _deviceService;
            categoryService = _categoryService;
            propertyService = _propertyService;
        }

        [HttpGet]
        public async Task<ActionResult> AddDevice()
        {
            List<Category> Categories = (await categoryService.GetCategories()).ToList<Category>();
            ViewBag.Cati_Id = new SelectList(Categories, "Cati_Id", "Cati_Name");
            ViewBag.DeviceList=deviceService.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddDevice(DeviceModel device)
        {
            if (ModelState.IsValid)
            {
                await deviceService.AddDevice(device);
                return RedirectToAction(nameof(AddDevice));
            }
            return View(device);
        }

        [HttpGet]
        public async Task<ActionResult> Update(int DeviceID)
        {
            Device device = deviceService.GetDevice(DeviceID);
            if (device != null)
            {
                List<Category> Categories = (await categoryService.GetCategories()).ToList<Category>();
                ViewBag.Cati_Id = new SelectList(Categories, "Cati_Id", "Cati_Name",device.Cati_Id);
                DeviceModel deviceModel = new DeviceModel
                {
                    Acquisition_Date = device.Acquisition_Date.ToString(),
                    Dev_Id = device.Dev_Id,
                    Dev_Name = device.Dev_Name,
                    Memo = device.Memo,
                    SerialNumber = device.SerialNumber,
                    PropertyValues = GetPropertyValueModels(device.PropertyValues)
                };
                return View(deviceModel);
            }
            else
                return HttpNotFound("Invalid Device Id");
            
        }

        [HttpPost]
        public async Task<ActionResult> Update(DeviceModel device)
        {
            if (ModelState.IsValid)
            {
                await deviceService.UpdateDevice(device);
                return RedirectToAction(nameof(AddDevice));
            }
            List<Category> Categories = (await categoryService.GetCategories()).ToList<Category>();
            ViewBag.Cati_Id = new SelectList(Categories, "Cati_Id", "Cati_Name", device.Cati_Id);
            return View(device);
        }

        [NonAction]
        public List<PropertyValueModel> GetPropertyValueModels(ICollection<PropertyValue> propertyValues)
        {
            List<PropertyValueModel> list = new List<PropertyValueModel>();
            foreach (PropertyValue item in propertyValues)
            {
                list.Add(new PropertyValueModel
                {
                    Description=item.Property.Description,
                    Prop_Id=item.Prop_Id,
                    Value=item.Value
                });
            }
            return list;
        }
    }
}