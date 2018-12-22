using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityApp.Models
{
    public class Visitor : Entity
    {
        [Required]
        public string FullName { get; set; }
        public string IIN { get; set; }
    }
}