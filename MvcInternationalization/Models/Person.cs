using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcInternationalization.Models
{
    public class Person
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "NameRequired")]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "AddressRequired")]
        public string Address { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
            ErrorMessageResourceName = "SocialNumberRequired")]
        public string SocialNumber { get; set; }
    }
}