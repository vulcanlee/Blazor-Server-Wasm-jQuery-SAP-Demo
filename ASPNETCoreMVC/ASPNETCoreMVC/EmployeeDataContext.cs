using ASPNETCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreMVC
{
   public class EmployeeDataContext : DbContext
   {
      public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
      {
      }

      public DbSet<Employee> Employee { get; set; }
   }
}