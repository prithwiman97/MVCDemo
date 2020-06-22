using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class MVCDemoContext:DbContext
    {
        public MVCDemoContext():base("Name=MVCDemoConnection")
        {

        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}