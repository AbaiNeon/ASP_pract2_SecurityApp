using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityApp.Models
{
    public class Employee : Entity
    {
        public string Position { get; set; }
        public string FullName { get; set; }
        public DateTime LastIncoming { get; set; }
    }
}