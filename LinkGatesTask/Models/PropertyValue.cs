using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkGatesTask.Models
{
    public class PropertyValue
    {
        public int Val_Id { get; set; }
        public int Prop_Id { get; set; }
        public int Dev_Id { get; set; }
        public string Value { get; set; }
        public Property Property { get; set; }
        public Device Device { get; set; }
    }
}