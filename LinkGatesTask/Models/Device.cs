using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Models
{
    public class Device
    {
        public int Dev_Id { get; set; }
        public string Dev_Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime Acquisition_Date { get; set; }
        public string Memo { get; set; }
        public int Cati_Id { get; set; }
        public Category Category { get; set; }
        public ICollection<PropertyValue> PropertyValues { get; set; }
    }
}