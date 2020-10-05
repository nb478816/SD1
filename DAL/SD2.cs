using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SD1.Models;

namespace SD1.DAL
{
    public class SD2Context : DbContext
    {
        public SD2Context() : base("Name=DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}