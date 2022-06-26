using jQuerySPA.Models;
using Microsoft.EntityFrameworkCore;

namespace jQuerySPA
{
   public class EmployeeDataContext : DbContext
   {
      public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
      {
      }

      public DbSet<Employee> Employee { get; set; }
   }
}