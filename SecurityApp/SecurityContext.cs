using SecurityApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SecurityApp
{
    public class SecurityContext : DbContext
    {
        public SecurityContext() : base("SecurityContext")
        {}

        public DbSet<Visitor> visitors { get; set; }
        public DbSet<Employee> employees { get; set; }


    }
}