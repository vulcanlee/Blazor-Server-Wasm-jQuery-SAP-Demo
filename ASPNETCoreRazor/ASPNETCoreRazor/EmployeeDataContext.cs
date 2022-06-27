using ASPNETCoreRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreRazor
{
   public class EmployeeDataContext : DbContext
   {
      public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
      {
      }

      public DbSet<Employee> Employee { get; set; }
   }
}