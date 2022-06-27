using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreRazor.Models
{
   public class Employee 
   {
      [Key]
      public int Id { get; set; }

      public string Name { get; set; }
      public string Gender { get; set; }
      public int? Salary { get; set; }
      public int? DepartmentId { get; set; }

      //public Department Department { get; set; }
   }
}