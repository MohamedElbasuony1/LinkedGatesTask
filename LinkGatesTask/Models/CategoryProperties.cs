using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Models
{
    public class CategoryProperties
    {
        public int Prop_Id { get; set; }
        public int Cati_Id { get; set; }
        public Property Property { get; set; }
        public Category Category { get; set; }
    }
}