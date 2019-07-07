using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LinkGatesTask.DTOs
{
    public class PropertyValueModel
    {
        public int Val_Id { get; set; }
        public int Prop_Id { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage ="Property Value is Required")]
        public string Value { get; set; }
    }
}