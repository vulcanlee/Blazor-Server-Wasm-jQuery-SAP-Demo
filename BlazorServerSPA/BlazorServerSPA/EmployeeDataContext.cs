using BlazorServerSPA.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSPA
{
   public class EmployeeDataContext : DbContext
   {
      public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
      {
      }

      public DbSet<Employee> Employee { get; set; }
   }
}