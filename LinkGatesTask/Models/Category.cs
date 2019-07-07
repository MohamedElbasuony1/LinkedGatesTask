using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Models
{
    public class Category
    {
        public int Cati_Id { get; set; }
        public string Cati_Name { get; set; }
        public ICollection<CategoryProperties> CategoryProperties { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}