using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Models
{
    public class Property
    {
        public int Prop_Id { get; set; }
        public string Description { get; set; }
        public ICollection<CategoryProperties> CategoryProperties { get; set; }
    }
}