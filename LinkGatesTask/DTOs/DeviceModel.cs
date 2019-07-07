using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LinkGatesTask.DTOs
{
    public class DeviceModel
    {
        public DeviceModel()
        {
            PropertyValues = new List<PropertyValueModel>();
        }
        public int Dev_Id { get; set; }

        [Display(Name ="Device Name")]
        [Required(ErrorMessage ="Device Name is Required")]
        public string Dev_Name { get; set; }
        [Display(Name ="Serial Number")]
        [Required(ErrorMessage ="Serial Number is Required")]
        public string SerialNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Acquition Date")]
        [Required(ErrorMessage ="Acquition date is required")]
        public string Acquisition_Date { get; set; }
        public string Memo { get; set; }
        [Display(Name ="Category Name")]
        [Required(ErrorMessage ="Category Name is required")]
        public int Cati_Id { get; set; }
        public List<PropertyValueModel> PropertyValues { get; set; }
    }
}