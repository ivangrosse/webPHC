using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CapitalHumanoPHC.Entities;

namespace CapitalHumanoPHC.Context
{
    public class DepartmentContext : DbContext
    {
       public DbSet<Department> Departments { get; set; }
    }
}