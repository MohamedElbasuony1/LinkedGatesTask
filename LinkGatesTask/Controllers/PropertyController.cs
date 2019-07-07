using LinkGatesTask.DTOs;
using LinkGatesTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkGatesTask.Controllers
{
    public class PropertyController : Controller
    {
        private readonly PropertyService propertyService;
        public PropertyController(PropertyService _propertyService)
        {
            propertyService = _propertyService;
        }
        // GET: Property
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetProperties(int CategoryID)
        {
            DeviceModel device = new DeviceModel();
            device.PropertyValues= propertyService.GetPropertiesByCategory(CategoryID);

            return PartialView(device);
        }

    }
}