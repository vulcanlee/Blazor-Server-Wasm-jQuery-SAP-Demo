using BlazorWasmSPA.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmSPA
{
   public class EmployeeDataContext : DbContext
   {
      public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
      {
      }

      public DbSet<Employee> Employee { get; set; }
   }
}